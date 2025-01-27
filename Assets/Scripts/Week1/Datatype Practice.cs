using UnityEngine;

public class DatatypePractice : MonoBehaviour
{


    int santaClaus;

    float Loki = 6.6f;
    public float meow;
    public float dog;

    char cat = 'C';

    string X = "wombat";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;
        santaClaus = santaClaus + 5 * 5 / 3 + 2;
        
        Debug.Log(santaClaus);

        Debug.Log(Loki);

        Loki = Loki - 2;

        Debug.Log("Loki's value is " + Loki);

        Debug.Log(cat + X );

        Loki = meow + dog;

        Debug.Log(Loki);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
