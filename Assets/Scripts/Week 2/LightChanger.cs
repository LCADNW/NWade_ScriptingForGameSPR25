using UnityEngine;

public class LightChanger : MonoBehaviour
{

    public Light lightThatChanges;

    public Vector3 lightMoveDirection;

    public bool IsOrIsNot = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.blue);
        lightThatChanges.color = Color.blue;
        this.gameObject.SetActive(IsOrIsNot);
    }

    // Update is called once per frame
    void Update()
    {
        AdjustLight();
        Debug.Log("LightObject has been adjusted");

        if (Input.GetKeyDown(KeyCode.L))
        {
            ChangeLightColor(Color.cyan);
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            ChangeLightColor(Color.red);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightThatChanges.gameObject.SetActive(false);

        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            lightThatChanges.gameObject.SetActive(true);
        }




    }
    private void AdjustLight()
    {
        lightThatChanges.transform.position += lightMoveDirection * Time.deltaTime;
        lightThatChanges.transform.localScale += Vector3.one * Time.deltaTime;
        lightThatChanges.intensity += 40f * Time.deltaTime;
        lightThatChanges.spotAngle += 10f * Time.deltaTime;







    }

    public void ChangeLightColor(Color santaClaus)
    {
        lightThatChanges.color = santaClaus;






    }









    private void OnEnable()
    {
        //When this object is set active again from inactive, it will call the code in this function
         
    }




}
