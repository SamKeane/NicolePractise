using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<Mammal> animals = new List<Mammal>()
    {
        new Dog("Doug"),
        new Hippo("Henry"),
        new Hippo("Holly"),
        new Dog("Dotty")
    };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        LogAnimals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LogAnimals()
    {
        foreach(var animal in animals)
        {
            Debug.Log($"I'm an animal, my name is {animal.Name}, I'm a {animal.GetType()}");

            if(animal is IPet)
            {
                Debug.Log("I'm also a Pet!");
            }
        }
    }
}
