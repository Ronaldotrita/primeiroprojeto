using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Playermove : MonoBehaviour
{
    public float Speed = 10f;
    public KeyCode MoveUp = KeyCode.UpArrow;
    public KeyCode MoveDown = KeyCode.DownArrow;
    public Rigidbody2D Myrigid;
    public Image UIplayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveUp))

            //transform.Translate(transform.up * Speed);
            Myrigid.MovePosition(transform.position + transform.up * Speed);
        else if (Input.GetKey(MoveDown))
            Myrigid.MovePosition(transform.position + transform.up * -Speed);

        //transform.Translate(transform.up * Speed * -1);


    }
    public void changecolor(Color c)
    {
        UIplayer.color = c;
    }

}

