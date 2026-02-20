using UnityEngine;

public class BananaPeel : MonoBehaviour
{
    public MoveScript player;
    public float z;
    public float decreaseSpeed;
    public float resetSpeed;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if()
        //    z = 0;
        //    player.moveSpeed += resetSpeed; 

        //    if (player.moveSpeed > player.defaultSpeed )
        //    {
        //        player.moveSpeed = player.defaultSpeed;
        //    }


        //if ( player.moveSpeed < 0)
        //{
        //    player.moveSpeed = 0;
        //}
        player.transform.eulerAngles -= new Vector3(0, 0, (z * Time.deltaTime));
    }

    public void Spin()
    {
        player.moveSpeed -= decreaseSpeed;
        z = 250; 
       
    }
}
