
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject alien;
    public List<GameObject> alienList;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 4; i++)
        {
            alienList.Add(alien);
            Instantiate(alien);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
        GameObject spawnedalien = alien.GetComponent<GameObject>();

           if(alien == null)
            {
                alienList.Remove(alien);
            }
     
        
    }
}
