using UnityEngine;
using System.Runtime.InteropServices;

public class NativeDLLTest : MonoBehaviour
{
    [DllImport("Native_Plugin", EntryPoint = "TestSort")]
    public static extern void TestSort(int[] a, int length);
    public void StartTest(int[] a)
    {
        TestSort(a, a.Length);
    }
}
