using UnityEngine;





public class HWScript2 : MonoBehaviour 

{
   
public float meow;
public float woof;
float total;






// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    total = meow + woof - woof + (woof * woof);
     Debug.Log(total);









    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
