using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    public float increaseSpeed;
    public float decreaseSpeed;
    public MoveScript movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.moveSpeed > movement.defaultSpeed)
        {
            movement.moveSpeed -= decreaseSpeed * Time.deltaTime;
        }
        else if (movement.moveSpeed < movement.defaultSpeed)
        {
            movement.moveSpeed = movement.defaultSpeed;
        }
    }

    public void upSpeed()
    {
        movement.moveSpeed += increaseSpeed; 

      
    }
}
