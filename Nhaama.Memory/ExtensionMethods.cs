using System;
using System.Diagnostics;
using System.Linq;
using Nhaama.Memory.Serialization;

namespace Nhaama.Memory
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get this Process as a Nhaama-wrapped Process.
        /// </summary>
        /// <returns>Nhaama-wrapped Process.</returns>
        public static NhaamaProcess GetNhaamaProcess(this Process process) => new NhaamaProcess(process);
        
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}