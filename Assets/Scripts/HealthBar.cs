using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer alien;
    public int health = 8; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
       
        if(alien.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            health -= 1;

            if (health <= 0)
            {
               Destroy(gameObject);
               
            }
        }

        healthBar.value = health;
    }
}
