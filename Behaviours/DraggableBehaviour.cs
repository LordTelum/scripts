using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DraggableBehaviour : MonoBehaviour
{
    
    private Camera cameraObj;
    public bool draggable;
    private Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        draggable = true;
        startDragEvent.Invoke();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }
    
    public void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
