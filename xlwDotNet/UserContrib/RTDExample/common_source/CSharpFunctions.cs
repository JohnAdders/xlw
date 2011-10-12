/*
 Copyright (C) 2008 2009  Narinder S Claire

 This file is part of XLWDOTNET, a free-software/open-source C# wrapper of the
 Excel C API - http://xlw.sourceforge.net/
 
 XLWDOTNET is part of XLW, a free-software/open-source C++ wrapper of the
 Excel C API - http://xlw.sourceforge.net/
 
 XLW is free software: you can redistribute it and/or modify it under the
 terms of the XLW license.  You should have received a copy of the
 license along with this program; if not, please email xlw-users@lists.sf.net
 
 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/



using System;
using System.Collections.Generic;
using System.Text;
using xlwDotNet;
using xlwDotNet.xlwTypes;
using System.Windows.Forms;
using Microsoft.Office.Core;
using XL = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Example
{
    public class Class1
    {

        [ExcelExport("Gets the time. Thats ALL !!", xlmCommandFlag = true)]
        public static CellMatrix GetTime()
        {
            return XlwExcel.RTD("RTDDemo", 1);
        }

        [ExcelExport("Gets the version. Thats ALL !!")]
        public static double ExcelVersion()
        {
            return XlwExcel.version;
        }
    }
}

