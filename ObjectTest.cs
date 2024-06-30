using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


using System;


public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string testConnectionResult = TestConnection();
        Debug.Log(testConnectionResult);
        int addResult = Add(1, 2);
        Debug.Log(addResult);
        string pbFunctionResult = PBFunction();
        Debug.Log(pbFunctionResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    [DllImport("pbtest.dll"), CallingConvention = CallingConvention.StdCall];
	public static extern string TestConnection();

    [DllImport("pbtest.dll"), CallingConvention = CallingConvention.StdCall];
	public static extern string PBFunction();

    [DllImport("pbtest.dll"), CallingConvention = CallingConvention.StdCall];
    public static extern int Add(int a, int b);

	
}
