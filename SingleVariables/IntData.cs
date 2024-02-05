using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}

