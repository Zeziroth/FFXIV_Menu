using GUI.Memory;
using System.Diagnostics;

namespace GUI
{
    public static class ExtensionMethods
    {
        public static CustomProcess GetNhaamaProcess(this Process process)
        {
            return new CustomProcess(process);
        }
    }
}