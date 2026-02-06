using UnityEngine;
using UnityEngine.UI;

public class ChatClock : MonoBehaviour
{
    public Slider chatSlider;
    public float clockDuration;

    public GameObject workerObject;

    private float timeWaiting = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chatSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime * 1;
        chatSlider.value = timeWaiting;

        if (timeWaiting >= clockDuration )
        {
            timeWaiting = 0;
            //Destroy(gameObject);
            Debug.Log("time is up");


            //WHEN TIMER IS up: 
            // turn th warper object off when it is on 
            // turn the warper object on when it is off

            bool shouldTurnOn = !workerObject.activeInHierarchy;
            bool shouldTurnOff = workerObject.activeInHierarchy;

            if(shouldTurnOff)
            {
                workerObject.SetActive(false);
            }

       

            if (shouldTurnOn)
            {
                workerObject.SetActive(true);
            }

        }
    }
}
