using UnityEngine;

public class Toybuttons : MonoBehaviour
{
    public GameObject tutorial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // created public methods to set the tutorial image to active and inactive 
    // mapped methods to UI buttons
    public void ClickTut() 
    {
        tutorial.SetActive(true);
    }

    public void ClickExit()
    {
        tutorial.SetActive(false);
    }
}
