﻿using Microsoft.CodeAnalysis.Diagnostics;

namespace H.Generators.Tests.Extensions;

/// <summary>
/// 
/// </summary>
public sealed class DictionaryAnalyzerConfigOptions : AnalyzerConfigOptions
{
    private Dictionary<string, string> Properties { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="properties"></param>
    public DictionaryAnalyzerConfigOptions(Dictionary<string, string> properties)
    {
        Properties = properties;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool TryGetValue(string key, out string value)
    {
        return Properties.TryGetValue(key, out value);
    }
}
