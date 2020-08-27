#ifndef DLL2_H
#define DLL2_H

// The following ifdef block is the standard way of creating macros which 
// make exporting from a DLL simpler.  The DLL2.cpp file is compiled with 
// the symbol DLL2_EXPORTS defined at the top of DLL2.cpp.  This symbol 
// should *not* be defined in any project that uses DLL2.  This way any 
// other project whose source files include DLL2.h will see DLL2_API defined 
// as __declspec(dllimport), whereas within DLL2.cpp, DLL2_API is defined as
// __declspec(dllexport).

#ifdef DLL2_EXPORTS
    #define DLL2_API __declspec(dllexport)
#else
    #define DLL2_API __declspec(dllimport)
#endif

///////////////////////////////////////////////////////////////////////////////
// This function is exported from the DLL2.dll
DLL2_API int __stdcall retornara();

#endif //DLL2_H
