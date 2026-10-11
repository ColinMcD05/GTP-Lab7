using Managed_Plugin;
using System.Diagnostics;
using UnityEngine;

public class FunctionTimer : MonoBehaviour
{
    public NativeDLLTest native;
    public Class1 class1;
    public MonoBehaviourTest test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        class1 = new Class1();
        MeasureFunctionExecutionTime();
    }

    void MeasureFunctionExecutionTime()
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start(); // Start timing
        native.StartTest(MyArray.GetArrayA()); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Native plugin took {elapsedMilliseconds} ms to execute.");
        stopwatch.Reset();

        stopwatch.Start(); // Start timing
        class1.TestSort(MyArray.GetArrayB()); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Managed plugin took {elapsedMilliseconds} ms to execute.");

        stopwatch.Start(); // Start timing
        test.TestSort(MyArray.GetArrayC()); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Monobehaviour took {elapsedMilliseconds} ms to execute.");
    }
}
