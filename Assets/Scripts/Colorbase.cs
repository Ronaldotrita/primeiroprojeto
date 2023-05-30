using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Colorbase : MonoBehaviour
{
    public Color color;
    public Image UIimagem;
    public Playermove Myplayer;
    public Playermove2 Myplayer2;

    // Start is called before the first frame update
    void Start()
    {
        UIimagem.color = color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onclic()
    {
        if(Myplayer != null)
        Myplayer.changecolor(color);
        if(Myplayer2 != null)
        Myplayer2.changecolor(color);
    }

}

