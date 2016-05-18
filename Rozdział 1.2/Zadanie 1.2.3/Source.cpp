#include <Windows.h>
#include <cstdio>
#include <ctime>
#include <cstdlib>

void lokajThread() {
	HANDLE sLokaj = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_LOKAJ");
	HANDLE sTyton = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_TYTON");
	HANDLE sBlotki = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_BLOTKI");
	HANDLE sZapalki = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_ZAPALKI");
	HANDLE sGlowny = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_GLOWNY");
	
	while (true) {
		WaitForSingleObject(sGlowny, INFINITE);
		int i = rand() % 3;
		switch (i) {
		case 0:
			printf("Lokaj wystawia blotki i zapalki\n");
			ReleaseSemaphore(sTyton, 1, NULL);
			break;
		case 1:
			printf("Lokaj wystawia tyton i zapalki\n");
			ReleaseSemaphore(sBlotki, 1, NULL);
			break;
		case 2:
			printf("Lokaj wystawia tyton i blotki\n");
			ReleaseSemaphore(sZapalki, 1, NULL);
			break;
		}
		ReleaseSemaphore(sGlowny, 1, NULL);
		WaitForSingleObject(sLokaj, INFINITE);
	}
}

void palaczThread(LPVOID *arg) {
	HANDLE sLokaj = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_LOKAJ");
	HANDLE sTyton = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_TYTON");
	HANDLE sBlotki = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_BLOTKI");
	HANDLE sZapalki = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_ZAPALKI");
	HANDLE sGlowny = OpenSemaphore(SEMAPHORE_ALL_ACCESS, false, "SEM_GLOWNY");
	
	
	int i = (int) arg;
	for (int count = 0; count < 10; ++count) {
		switch (i) {
		case 0:
			WaitForSingleObject(sTyton, INFINITE);
			WaitForSingleObject(sGlowny, INFINITE);

			printf("Palacz z tytoniem zapala papierosa\n");

			ReleaseSemaphore(sLokaj, 1, NULL);
			ReleaseSemaphore(sGlowny, 1, NULL);
			break;
		case 1:
			WaitForSingleObject(sBlotki, INFINITE);
			WaitForSingleObject(sGlowny, INFINITE);
			
			printf("Palacz z blotkami zapala papierosa\n");

			ReleaseSemaphore(sLokaj, 1, NULL);
			ReleaseSemaphore(sGlowny, 1, NULL);
			break;
		case 2:
			WaitForSingleObject(sZapalki, INFINITE);
			WaitForSingleObject(sGlowny, INFINITE);
			
			printf("Palacz z zapa³kami zapala papierosa\n");

			ReleaseSemaphore(sLokaj, 1, NULL);
			ReleaseSemaphore(sGlowny, 1, NULL);
			break;
		}
	}
}


int main() {
	srand((unsigned)time(NULL));
	HANDLE lokaj, palacze[3];
	HANDLE sLokaj = CreateSemaphore(NULL, 0, 1, "SEM_LOKAJ");
	HANDLE sTyton = CreateSemaphore(NULL, 0, 1, "SEM_TYTON");
	HANDLE sBlotki = CreateSemaphore(NULL, 0, 1, "SEM_BLOTKI");
	HANDLE sZapalki = CreateSemaphore(NULL, 0, 1, "SEM_ZAPALKI");
	HANDLE sGlowny = CreateSemaphore(NULL, 1, 1, "SEM_GLOWNY");

	
	for (int i = 0; i < 3; ++i) {
		palacze[i] = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE) palaczThread ,(LPVOID) i, NULL, NULL);
	}

	lokaj = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)lokajThread, NULL, NULL, NULL);
	WaitForMultipleObjects(3, palacze, true, INFINITE);
	for (int i = 0; i < 3; ++i) {
		TerminateThread(palacze[i], 0);
		CloseHandle(palacze[i]);
	}
	TerminateThread(lokaj, 0);
	CloseHandle(lokaj);
	getchar();
	return 0;
}