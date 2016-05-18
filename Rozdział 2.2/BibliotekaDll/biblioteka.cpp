extern "C" {
	__declspec(dllexport) int _stdcall IsPrimeC(int x) {
		for (int c = 2; c <= x - 1; c++)
		{
			if (x%c == 0)
			{
				return 0;
			}
		}
		return x >= 2;
	}

	
}

extern "C" {
	__declspec(dllexport) int _stdcall ExecuteC(int n,  int ( _stdcall *f)(int)) {
		return f(n);
	}
}