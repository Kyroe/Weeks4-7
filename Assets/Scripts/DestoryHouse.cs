using UnityEngine;
using UnityEngine.InputSystem;

public class DestoryHouse : MonoBehaviour
{
    public SpriteRenderer house;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (house.bounds.Contains(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())) && Mouse.current.leftButton.wasPressedThisFrame) 
        {
            Destroy(gameObject);
        }
    }
}
