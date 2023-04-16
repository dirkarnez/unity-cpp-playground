using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;

public class CppButton : MonoBehaviour
{
    [DllImport("lookup_table")]
    private extern static void GetRandomNumberArrayOfLength10(int[] arr);

    public void TestGetRandomNumberArrayOfLength10()
    {
        int[] array = new int[10];

        GetRandomNumberArrayOfLength10(array);

        GameObject.Find("Button").GetComponentInChildren<Text>().text = String.Join(",", array);
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(array[i]);
        }
    }
}