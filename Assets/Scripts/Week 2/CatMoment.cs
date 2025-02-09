using UnityEngine;

public class CatMoment : MonoBehaviour
{
    public GameObject evilcat;

    public float scaleIncrease = .5f;

    public GameObject youDiedScreen;

    public Transform teleportTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        evilcat.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(evilcat.transform.localScale.x > 80)
        {
            youDiedScreen.SetActive(true);

        }

      




    }

    public void Resetevilcat()
    {
        evilcat.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }

    public void rotateEvilcat()
    {
        evilcat.transform.Rotate(new Vector3(0f, 0f, -90f));

      
    }

    public void TeleportEvilcat()
    {
        evilcat.transform.position = teleportTransform.position;
    }
}
