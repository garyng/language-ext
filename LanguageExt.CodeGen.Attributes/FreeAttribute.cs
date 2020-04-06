﻿using System;
using System.Diagnostics;
using CodeGeneration.Roslyn;

namespace LanguageExt
{
    /// <summary>
    /// Union attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [CodeGenerationAttribute("LanguageExt.CodeGen.FreeGenerator, LanguageExt.CodeGen.Generator")]
    [Conditional("CodeGeneration")]
    public class FreeAttribute : Attribute
    {
    }
}