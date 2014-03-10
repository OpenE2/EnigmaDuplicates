﻿using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
using log4net.Config;

[assembly: AssemblyTitle("Enigma Duplicates")]
[assembly: AssemblyDescription("Utility for Enigma1 & Enigma2 settings management")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Krkadoni.com")]
[assembly: AssemblyProduct("Enigma Duplicates")]
[assembly: AssemblyCopyright("Copyright © Krkadoni.com 2013")]
[assembly: AssemblyTrademark("Krkadoni.com")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("8e6b9c72-dd43-4622-9cb6-ad27b55f6870")]

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
[assembly: AssemblyVersion("0.001")]
[assembly: AssemblyFileVersion("0.001")]
[assembly: XmlConfigurator(ConfigFile = "EnigmaDuplicates.log4net", Watch = true)]
[assembly: NeutralResourcesLanguage("en")]