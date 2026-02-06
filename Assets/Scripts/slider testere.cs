using UnityEngine;

public class slidertestere : MonoBehaviour
{
    public float currentSliderValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void valueChanged(float value)
    {
        currentSliderValue = value;
    }
}
