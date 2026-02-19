using UnityEngine;

public class CarDie : MonoBehaviour
{
   
    public float bounds;
    public float fallSpeed;
    public float dist;
    public Transform boxPos;
    //getcomps from cat spawner will pass into here 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if cats are within a certain dist to the box, destroy cat
        //using dist so that cats are visible with the box for a more realistic look 
        dist = Vector3.Distance(boxPos.position, transform.position); 
        if (dist < bounds)
        { 
            Destroy(gameObject);
        }

        //make cat fall 
        Vector2 carPos = (Vector2)transform.position;
        carPos.y -= fallSpeed * Time.deltaTime;
        transform.position = carPos;
           
        //if cat is lower than the screen, destory
        if (carPos.y < -10)
        { 
            Destroy (gameObject);
        }
    }
}
