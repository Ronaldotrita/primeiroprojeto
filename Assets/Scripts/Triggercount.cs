using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Triggercount : MonoBehaviour
{
    public int Gols;
    public TextMeshProUGUI Textoplacar;
    public TextMeshProUGUI Textofim;
    public GameObject Telainicial;
    public TextMeshProUGUI atualvencedor;
    public TextMeshProUGUI nomejogador;

    private void fimdejogo()
    {
        Textofim.text = "FIM DE JOGO";
        Telainicial.SetActive(true);
        zerarplacar();
        atualvencedor.text = nomejogador.text;
    }
    private void zerarplacar()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Gols = 0;
            Textoplacar.text = Gols.ToString();
        }
            
    }

    private void Awake()
    {
        Gols = 0;
        Textoplacar.text = Gols.ToString();
        Textofim.text = "";
        

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zerarplacar();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Gols++;
        Debug.Log("Gol !!");
        Textoplacar.text = Gols.ToString();
        if (Gols >=3)
        {
            fimdejogo();
        }

    }

   
}
