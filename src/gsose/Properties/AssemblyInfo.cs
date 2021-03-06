﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("gsose")]
[assembly: AssemblyDescription("Grand Son Of Strike Extension for WinDBG")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("gsose")]
[assembly: AssemblyCopyright("Copyright © Christophe Nasarre 2016-2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3fca8012-3bad-41e4-91f4-534aa9a44f96")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.6.0")]
[assembly: AssemblyFileVersion("1.6.0")]
//
// version 1.6
// -----------------------------------------
//  - add pstacks command to show merged parallel stacks
//
//
//
// version 1.5.3
// -----------------------------------------
//  - add -stat to gcinfo: show a dumpheap -stat per segment and per generation
//
//
//
// version 1.5.2
// -----------------------------------------
//  - use ClrMDExports (from Kevin Gosse) to allow lldb/WinDBG extension
//
//
// version 1.5.1
// -----------------------------------------
//  - bug fix for .NET Core CLR 2.0/2.1 --> 2.2 structure changes for thread pool work item callback
//  - use UnmanagedExports.Repack nuget package (from Kevin Gosse)
//
//
// version 1.5
// -----------------------------------------
//  - add dcq (Dump concurrent queue) command
//  - support Core CLR 2.0/2.1/2.2 structure changes
//      thread pool
//      timers
//      concurrent queue
//      concurrent dictionary
//  - update to 2019
//
//
// version 1.4
// -----------------------------------------
//  - add dcd (Dump concurrent dictionary) command
//  - fix deprecated symbols
//  - use netstandard DynaMD version and 1.0 version of ClrMD
//  - fix miscellaneous issues in DML
//
//
// version 1.3
// -----------------------------------------
//  - add po (PinnedObjects) command
//  - add gci (GCInfo) command
//
//
// version 1.2
// -----------------------------------------
//  - add gmn command
//  - make the project public on github
//
// version 1.1
// -----------------------------------------
//  - share ClrMDHelper with ClrMDStudio
//  - split tpinfo command into 2 commands (tpQueues/tpq and tpRunning/tpr)
//  - add timers info (tInfo/ti)
//  - add "help" command
//