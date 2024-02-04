using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class spriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
}
