using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Declare a game object variable which defines the target when should look at
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("Change look target is not specifed. defaulting to parent object");
        }
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
    

}
