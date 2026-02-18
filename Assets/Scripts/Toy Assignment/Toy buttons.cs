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

    public void ClickTut()
    {
        tutorial.SetActive(true);
    }

    public void ClickExit()
    {
        tutorial.SetActive(false);
    }
}
