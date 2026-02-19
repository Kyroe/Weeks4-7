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
        //set the box's x value to the same as the slider 
        // set the slider values in code

        Vector2 boxPos = (Vector2)transform.position;
        pos.maxValue = 6;
        pos.minValue = -6;
        boxPos.x = pos.value;
        transform.position = boxPos;
    }
}
