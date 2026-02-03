using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float z = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, z);
    }

    public void StartSpin()
    {
        z = 100;
    } 

    public void StopSpin()
    {
        z = 0;
    }

    
}
