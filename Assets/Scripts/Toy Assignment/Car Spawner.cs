using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CarSpawner : MonoBehaviour
{
    public GameObject box;
    public float time;
    private Vector3 pos;
    public GameObject cat;
    public CarDie catScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        //set cat prefab position to a variable 
        //set timer to a random number so that cats spawn in random intervals 
        //start with spawning a cat to avoid delays 
        cat.transform.position = pos;
        time = Random.Range(2, 3);
        CatSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        //  have timer countdown, if reaches 0, spawn a new cat, reset timer to a random interval 
        time -= Time.deltaTime;
        if (time < 0)
        {
            CatSpawn();
            time = Random.Range(0.5f, 2);
        }
    }

    // created new method for simplicity
    void CatSpawn()
    {
        //set the cat's x pos to a random range within the box's range 
        //get the box's transform.pos
        //get the car's moving/destory script and insert the box's tranform.pos and randomize the fall speed 
        pos = new Vector3(Random.Range(-6, 6),7, 0);
        Transform getBox = box.transform;
        CarDie carDie = catScript.GetComponent<CarDie>();
        catScript.fallSpeed = Random.Range(5, 8);
        catScript.boxPos = getBox;

        Instantiate(cat,pos, Quaternion.identity);
        
    }


}

