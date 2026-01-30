using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabSpawner;

    public float waitTime;
    public float destroyTime;
    public Color pacerColor;
    public float pacerSpeed;

    private float progress;
    private float destroyProgress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //EMPTY VECTOR3
        Vector3 originPosition = Vector3.zero;

        //EMPTY ROTATION
        Quaternion originRotation = Quaternion.identity;

        // Instantiate(spawningPrefab, transform.position, Quaternion.identity);

        //SPAWNING AT THE POSITION OF THE SPAWNER (WITH THE SPAWNER'S ROTATION)
        //Instantiate(spawningPrefab, transform.position, transform.rotation);

        //SPAWNING AT THE ORIGIN
        //Instantiate(spawningPrefab); 
       
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate(prefabSpawner, transform.position, Quaternion.identity);
       progress += Time.deltaTime;
        
        if(progress > waitTime)
        {
            GameObject spawnedObject = Instantiate(prefabSpawner, transform.position, Quaternion.identity);

            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = pacerSpeed;

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColor;

            Destroy(spawnedObject, destroyTime);
            progress = 0;
        }

        //typeOfComponent variableName = variableOfObject.GetComponent<typeOfComponent>();
        

        //destroyProgress += Time.deltaTime;
        //if(destroyProgress > destroyTime)
        //{
        //    Destroy(gameObject);
        //}
    }
}
