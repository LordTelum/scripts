using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idObj);
    }
}
