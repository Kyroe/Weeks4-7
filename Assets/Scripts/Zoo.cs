using UnityEngine;
using System.Collections.Generic;

public class Zoo : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animals.Add("snake");
        //animals.Remove("gorilla");

        //string selectedanimal = animals[3];

        //Debug.Log(selectedanimal);

        //for(int i = 0; i < animals.Count; i++)
        //{
        //    string currentAnimal = animals[i];
        //    Debug.Log(currentAnimal);

        //    animals.Clear(); //gets rid of everything 

        //}

        Animal newCat = new Animal("cat", "tiger", 5);

        animals.Add(newCat);

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Animal
    {
        public string type;
        public string name;
        public int age;
        public Color color;
        public float size;
        public string sex;

        public Animal(string inType, string inName, int inAge)
        {
            type = inType;
            name = inName;
            age = inAge;
        }
    }
}
