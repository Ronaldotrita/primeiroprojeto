using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playername : MonoBehaviour
{

    public TextMeshProUGUI Nometelainicial;
    public TextMeshProUGUI Nometelajogo;
    public TMP_InputField nomeescolhido;
    public void trocanome()
    {
        Nometelajogo.text = nomeescolhido.text;
        Nometelainicial.text = Nometelajogo.text;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
