namespace LuaMC.UI;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//public enum TokenType
//{
//    Identifier, Keyword, Number, String, Symbol, Operator, Boolean, Nil, EndOfFile
//};
//
//[StructLayout(LayoutKind.Sequential)]
//public struct CSToken
//{
//    public TokenType Type;
//    public string Value;
//}

public class _LuaMC
{
    //[DllImport("LuaMC.Compiler.dll", CallingConvention = CallingConvention.Cdecl)]
    //public static extern IntPtr Tokenize(string src, out int tokeenCount);

    [DllImport("LuaMC.Compiler.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Build(string src, string buildDir);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void LogCallback(string msg);

    [DllImport("LuaMC.Compiler.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void SetLogCallback(LogCallback callback);

    //[DllImport("kernel32.dll", SetLastError = true)]
    //private static extern void CoTaskMemFree(IntPtr ptr);
    //
    //public static List<CSToken> ToCSTokens(IntPtr tokensPtr, int tokenCount)
    //{
    //    List<CSToken> tokens = new List<CSToken>();
    //    IntPtr curPtr = tokensPtr;
    //
    //    for (int i = 0; i < tokenCount; i++)
    //    {
    //        CSToken token = Marshal.PtrToStructure<CSToken>(curPtr);
    //
    //        IntPtr valuePtr = curPtr + Marshal.OffsetOf<CSToken>("Value").ToInt32();
    //        string value = Marshal.PtrToStringAnsi(valuePtr);
    //
    //        token.Value = value;
    //        tokens.Add(token);
    //
    //        curPtr = (IntPtr)(curPtr.ToInt64() + Marshal.SizeOf<CSToken>());
    //    }
    //
    //    return tokens;
    //}
}
