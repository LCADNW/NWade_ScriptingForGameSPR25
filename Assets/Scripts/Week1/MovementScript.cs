 using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");

        this.transform.position = startingPosition;

        

    }

    // Update is called once per frame
    void Update()
    {
        //Move direction is currently (1,0,1)
        this.transform.position += moveDirection *  speed * Time.deltaTime;
        
        
        
        
        
        
        
        
        
        
        
        Debug.Log("Meow.");
    }
}
