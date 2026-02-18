using UnityEngine;

public class CarDie : MonoBehaviour
{
   // public GameObject box;
    public float bounds;
    public float fallSpeed;
    public float dist;
    public Transform boxPos;
    //public AudioSource MEOW;
    //public AudioClip hiss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        dist = Vector3.Distance(boxPos.position, transform.position);
        if (dist < bounds)
        {
           
            Destroy(gameObject);
        }

        Vector2 carPos = (Vector2)transform.position;

        carPos.y -= fallSpeed * Time.deltaTime;
        transform.position = carPos;

        //if (carPos.y < -6)
        //{
        //    MEOW.PlayOneShot(hiss);
        //}
           
        if (carPos.y < -10)
        {
           
            Destroy (gameObject);
        }
    }
}
