using UnityEngine;

public class CarDie : MonoBehaviour
{
    public GameObject box;
    public float bounds;
    public float fallSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform boxPos = box.transform;
        float dist = Vector3.Distance(transform.position, boxPos.position);
        if (dist < bounds)
        {
            Destroy(gameObject);
        }

        Vector2 carPos = (Vector2)transform.position;

        carPos.y -= fallSpeed * Time.deltaTime;
        transform.position = carPos;

        if (carPos.y < -7)
        {
            Destroy (gameObject);
        }
    }
}
