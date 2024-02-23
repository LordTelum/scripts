using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent repeatEvent;
    public int counterNum = 3;
    public float seconds = 1.0f;
    private WaitForSeconds wfsOBJ;
    private WaitForFixedUpdate wffuOBJ;
    
    IEnumerator Start()
    {
        wfsOBJ = new WaitForSeconds(seconds);
        wffuOBJ = new WaitForFixedUpdate();
        
        while (counterNum > 0)
        {
            yield return wfsOBJ;
            repeatEvent.Invoke();
            counterNum--;
            Debug.Log(counterNum);
        }
        
        
    }
}
