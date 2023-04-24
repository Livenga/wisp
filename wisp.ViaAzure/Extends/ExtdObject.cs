namespace wisp.ViaAzure;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Linq;


/// <summary></summary>
public static class ExtdObject
{
    /// <summary></summary>
    public static void DisplayProperties(
            this object o,
            string defValue = "null")
    {
        var type = o.GetType();
        var props = type.GetProperties();
        var maxLength = props.Max(p => p.Name.Length);
        var format = $"\t{{0,-{maxLength}}} {{1}}";

        Debug.WriteLine($"{type.FullName}");
        foreach(var prop in props)
        {
            try
            {
                Debug.WriteLine(string.Format(
                            format,
                            prop.Name,
                            prop.GetValue(o)?.ToString() ?? defValue));
            }
            catch { }
        }
    }
}
