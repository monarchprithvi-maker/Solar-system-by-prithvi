
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // declaring a variable for a select target
        public Transform target;
    public int speed;
         // start is called before the first from update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()  
    {
        //Rotate Around the first parameter target position
        // Rotate Around need second parameter about the axis or rotation.
        //Rotate Around third parameter needed is the speed of rotation.
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
