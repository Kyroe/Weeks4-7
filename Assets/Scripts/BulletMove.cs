using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMove : MonoBehaviour
{
    public GameObject bullet;
    public GameObject trans;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Transform Trans = trans.transform; // transform is a GetComp, thats why we can shorten it to just transform 
                Instantiate(bullet, Trans.position, Trans.rotation);

        }

        
    }
}
