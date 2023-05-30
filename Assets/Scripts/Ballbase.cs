using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballbase : MonoBehaviour
{

    public Vector3 Speed = new Vector3(1, 1);
  

    [Header("Randomization")]
    public Vector2 Randomspeedx = new Vector2(1, 3);
    public Vector2 Randomspeedy = new Vector2(1, 3);

    private Vector2 posicaoinicial;
    private bool canmove = false;

    private void resetball()
    {
        transform.position = posicaoinicial;
        canmove = false;
    }



    private void Awake()
    {
        posicaoinicial = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


        
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
            canmove = true;
        if (canmove) //nao preciso colocar =  true pq o SE vai entender que soh passa se for valido ou seja TRUE
            transform.Translate(Speed);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Playermove>() != null)
        {
            OnplayerCollision();

        }


        else if (collision.gameObject.GetComponent<Playermove2>() != null)
        {
            OnplayerCollision();
        }

        else
            Speed.y *= -1;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Triggercount>() != null)
            resetball();
    }
    private void OnplayerCollision()
    {
        Speed.x *= -1;
        float rand = Random.Range(Randomspeedx.x, Randomspeedy.y);

        if (Speed.x < 0)
            rand = -rand;
        Speed.x = rand;
    }

}
