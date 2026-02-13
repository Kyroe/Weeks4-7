using UnityEngine;

public class BulletMOVER : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new (Vector2)transform.position;
        move += Vector2.one * moveSpeed * Time.deltaTime;
    }
}
