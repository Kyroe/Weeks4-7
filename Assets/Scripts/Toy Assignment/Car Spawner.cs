using UnityEngine;
using UnityEngine.UIElements;

public class CarSpawner : MonoBehaviour
{
    public GameObject box;
    public float time;
    private Vector3 pos;
    public GameObject cat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
        cat.transform.position = pos;
        time = Random.Range(2, 3);
        CatSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject getBox = box.GetComponent<GameObject>();
        time -= Time.deltaTime;
        if (time < 0)
        {
            CatSpawn(); 
            time = Random.Range(3, 5);
        }
    }

    void CatSpawn()
    {
        pos = new Vector3(Random.Range(-6, 6),7, 0);
        Instantiate(cat,pos, Quaternion.identity);
    }


}

