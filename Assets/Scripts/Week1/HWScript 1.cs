using UnityEngine;

public class HWScript1 : MonoBehaviour
{
//setting up integers
   int Meow;

        int Woof;
       
        int Bork;

        int total;












// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   //etsablishing values of int

       Meow = 5;
       Woof = 6;
       Bork = 7;

       total = total + Meow * (Woof * 4) - Bork + (Bork *3);

       Debug.Log(total);








    }

    // Update is called once per frame
    void Update()
    {
        















    }
}
