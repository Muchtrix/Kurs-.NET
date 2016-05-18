// dllmain.cpp : Implementation of DllMain.

#include "stdafx.h"
#include "resource.h"
#include "BibliotekaPrime_i.h"
#include "dllmain.h"

CBibliotekaPrimeModule _AtlModule;

// DLL Entry Point
extern "C" BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	hInstance;
	return _AtlModule.DllMain(dwReason, lpReserved); 
}

extern "C" int IsPrime(int x) {
	for (int c = 2; c <= x - 1; c++)
	{
		if (x%c == 0)
		{
			return 0;
		}
	}
	return x >= 2;
}
