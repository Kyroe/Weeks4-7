using UnityEngine;
using UnityEngine.InputSystem;

public class Description : MonoBehaviour
{
    public GameObject description;
    public SpriteRenderer duck;
    public bool isHover;
    public Vector3 mousePosition;
    public Vector3 spritePosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0;
        spritePosition = transform.position;


        isHover = duck.bounds.Contains(mousePosition);


        if (isHover)
        {
            description.SetActive(true);
        }
        else
        {
            description.SetActive(false);
        }
    }
}
