using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;


public partial class Program
{
    static void Main(string[] args)
    {
        string testConnectionResult = TestConnection();
        Debug.WriteLine(testConnectionResult);
        int addResult = Add(1, 2);
        Debug.WriteLine(addResult);
        string pbFunctionResult = PBFunction();
        Debug.WriteLine(pbFunctionResult);
    }

    [LibraryImport("pbtest.dll", StringMarshalling = StringMarshalling.Utf16)]
	public static partial string TestConnection();

    [DllImport("pbtest.dll")]
	public static extern string PBFunction();

    [LibraryImport("pbtest.dll")]
    public static partial int Add(int a, int b);


}

