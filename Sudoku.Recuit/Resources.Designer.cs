﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.Recuit {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sudoku.Recuit.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to import ctypes
        ///
        ///import numpy as np
        ///
        ///import clr 
        ///import System
        ///from System import Array, Int32
        ///from System.Runtime.InteropServices import GCHandle, GCHandleType
        ///
        ///_MAP_NP_NET = {
        ///    np.dtype(np.float32): System.Single,
        ///    np.dtype(np.float64): System.Double,
        ///    np.dtype(np.int8)   : System.SByte,
        ///    np.dtype(np.int16)  : System.Int16,
        ///    np.dtype(np.int32)  : System.Int32,
        ///    np.dtype(np.int64)  : System.Int64,
        ///    np.dtype(np.uint8)  : System.Byte,
        ///    np.dtype(np.uint16) : System.UInt1 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string numpy_converter_py {
            get {
                return ResourceManager.GetString("numpy_converter.py", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to import random
        ///import numpy as np
        ///import math
        ///from random import choice
        ///import statistics
        ///import copy
        ///from simanneal import Annealer
        ///
        ///
        ///# sudoku instance, we use &apos;0&apos; for empty cells
        ///#instance = ((0,0,0,0,9,4,0,3,0),
        ///#            (0,0,0,5,1,0,0,0,7),
        ///#            (0,8,9,0,0,0,0,4,0),
        ///#            (0,0,0,0,0,0,2,0,8),
        ///#            (0,6,0,2,0,1,0,5,0),
        ///#            (1,0,2,0,0,0,0,0,0),
        ///#            (0,7,0,0,0,0,5,2,0),
        ///#            (9,0,0,0,6,5,0,0,0),
        ///#            (0,4,0,9,7,0,0,0,0))
        ///
        ///
        ///#su [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RecuitSolver_py {
            get {
                return ResourceManager.GetString("RecuitSolver.py", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to import clr
        ///clr.AddReference(&quot;Sudoku.Shared&quot;)
        ///clr.AddReference(&quot;Sudoku.Recuit&quot;)
        ///from Sudoku.Recuit import SudokuRecuitSolver
        ///netSolver = SudokuRecuitSolver()
        ///solvedSudoku = netSolver.Solve(sudoku).
        /// </summary>
        internal static string SelfCallSolver_py {
            get {
                return ResourceManager.GetString("SelfCallSolver.py", resourceCulture);
            }
        }
    }
}
