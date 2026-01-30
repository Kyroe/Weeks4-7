using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class flipper : MonoBehaviour
{
    public float speed = 0;
    public float direction = 1; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * transform.right * speed * Time.deltaTime;
    }

    public void OnMoveClick()
    {
        speed = 4;
       // transform.position += direction * transform.right * speed * Time.deltaTime;
    } 
    public void OnStopClick()
    {
        speed = 0;
    }

    public void OnFlipClick()
    {
        direction *= -1;
    }
}
