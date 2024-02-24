using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    
    public UnityEvent disableEvent;
    
    public void SetValue(int num)
    {
        value = num;
    }
    
    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    public void UpdateValue(int num)
    {
        value += num;
    }
    
    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}

