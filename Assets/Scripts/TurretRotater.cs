using UnityEditor.Experimental.GraphView;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurretRotater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentMousePosition = Mouse.current.position.ReadValue();
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
       

        Vector2 direction = worldMousePosition - (Vector2)transform.position;

        transform.up = direction;

        Vector3 rotation = Quaternion.;

        if (rotation.z >= 0 )
        {
            rotation.z = 0;
        }
        
        if (rotation.z <= -90)
        {
            rotation.z = -90;
        }
        
    }
}
