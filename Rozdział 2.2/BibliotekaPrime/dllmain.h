// dllmain.h : Declaration of module class.

class CBibliotekaPrimeModule : public ATL::CAtlDllModuleT< CBibliotekaPrimeModule >
{
public :
	DECLARE_LIBID(LIBID_BibliotekaPrimeLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_BIBLIOTEKAPRIME, "{DEC8D45A-0B11-4FCB-8C67-178FCF026487}")
};

extern class CBibliotekaPrimeModule _AtlModule;
