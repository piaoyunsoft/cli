﻿using System.Collections.Generic;
using System.Linq;

namespace Microsoft.DotNet.Cli.Compiler.Common
{
    internal static class DepsFormatter
    {
        internal static string EscapeRow(IEnumerable<string> values)
        {
            return values
                .Select(EscapeValue)
                .Aggregate((a, v) => a + "," + v);
        }

        internal static string EscapeValue(string value)
        {
            return "\"" + value.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
        }
    }
}
