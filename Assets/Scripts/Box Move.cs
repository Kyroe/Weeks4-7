using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BoxMove : MonoBehaviour
{
    public Slider pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //mousePos.z =0;
        //transform.position = mousePos;

        Vector2 boxPos = (Vector2)transform.position; 
        boxPos.x = pos.value;
        transform.position = boxPos;
    }
}
