using UnityEngine;

public class HWScript3 : MonoBehaviour
{
    

string FullSentence;
public string first;
public string second;
public string third;



// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FullSentence = (first + second + third);
        
        Debug.Log(FullSentence);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
