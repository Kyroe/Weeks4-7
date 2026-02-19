using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float z;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //rotate overtimes
        transform.eulerAngles += new Vector3(0, 0, (z * Time.deltaTime));
    }


    
}
