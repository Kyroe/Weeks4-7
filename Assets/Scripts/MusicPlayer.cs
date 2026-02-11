using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource bg;
    public Slider musicPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        musicPlayer.minValue = 0;
        musicPlayer.maxValue = 159;
        musicPlayer.value = bg.time;
    }

}
