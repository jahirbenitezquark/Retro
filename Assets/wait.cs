using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
{
    // In this example we show how to invoke a coroutine and
    // continue executing the function in parallel.

    public IEnumerator coroutine;


    public void Cambio()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(0.5f);
       
        StartCoroutine(coroutine);

        
    }

    // every 2 seconds perform the print()
    public IEnumerator WaitAndPrint(float waitTime)
    {
        
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            
            
            SceneManager.LoadScene("Menu");
        }
    }
    
}

