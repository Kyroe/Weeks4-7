using UnityEngine;
using UnityEngine.InputSystem;

public class HouseSpawner : MonoBehaviour
{
    public GameObject housePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // transform.position = (Vector2)transform.position + Random.insideUnitCircle * 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Random.insideUnitCircle * 8;

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            SpawnHouse();
        }
    }

    public void SpawnHouse()
    {
        Instantiate(housePrefab, transform.position, Quaternion.identity);
    }
}
