using UnityEngine;
using UnityEngine.Events;

public class DayNightCycle : MonoBehaviour
{
    //duration of the day in seconds
    public float dayLength = 120f;
    public UnityEvent morningEvent, afternoonEvent, nightEvent;
    
    private float rotationSpeed;
     //0 is midnight, 0.5 is noon
    private float timeOfDay;
    
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 360f / dayLength;
    }
    
    void Update()
    {
        //rotate the sun around the y axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        
        //update the time of day
        timeOfDay += Time.deltaTime / dayLength;
        
        //if it is morning
        if (timeOfDay > 0.25f && timeOfDay < 0.26f)
        {
            morningEvent.Invoke();
        }
        
        //if it is afternoon
        if (timeOfDay > 0.5f && timeOfDay < 0.51f)
        {
            afternoonEvent.Invoke();
        }
        
        //if it is night
        if (timeOfDay > 0.75f && timeOfDay < 0.76f)
        {
            nightEvent.Invoke();
        }
        
        //reset the time of day
        if (timeOfDay > 1f)
        {
            timeOfDay -= 1f;
        }
    }
}
