﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

[assembly: AssemblyTitle("Data Grid Extensions")]
[assembly: AssemblyDescription("This package contains useful extensions for the MS DataGrid (System.Windows.Controls.DataGrid).\r\nThe current version supports the following features:\r\n- Add filtering capabilities to the DataGrid.\r\n- Correctly apply initial sorting criteria.\r\n- Easy to use\r\n- Easy to customize\r\n- Attaches to the existing DataGrid")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("tom-englert.de")]
[assembly: AssemblyProduct("Tom's Toolbox")]
[assembly: AssemblyCopyright("Copyright © 2012-2017 tom-englert.de, Germany")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
[assembly: Guid("26c621e5-4dac-4f34-b534-9bb334d6380b")]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]

[assembly: XmlnsPrefix("urn:tom-englert.de/DataGridExtensions", "dgx")]
[assembly: XmlnsDefinition("urn:tom-englert.de/DataGridExtensions", "DataGridExtensions")]
[assembly: XmlnsDefinition("urn:tom-englert.de/DataGridExtensions", "DataGridExtensions.Behaviors")]

[assembly: AssemblyVersion(Product.Version)]
[assembly: AssemblyFileVersion(Product.Version)]

// ReSharper disable once CheckNamespace
internal static class Product
{
    public const string Version = "1.0.37.0";
}

