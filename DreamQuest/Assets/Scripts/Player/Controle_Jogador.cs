using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controle_Jogador : MonoBehaviour
{
    public Transform groundCheck;
    private Rigidbody2D rb;
    public LayerMask layerPulavel;

    public float speedPulo = 4f;
    public float speed = 10f;

    public bool pulando = false;
    public bool noChao = false;
    public float countPulo = 0.5f;

    public float maior = 0;

    
    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  
        
        // pulo variavel comando
        if (Input.GetButtonDown("Jump"))
        {
            if(noChao)
            {
               pulando = true;
            }
        }
        if (Input.GetButton("Jump"))
        {
            countPulo -= Time.deltaTime;
        }
        if (Input.GetButtonUp("Jump"))
        {
            countPulo = 0.5f;
            pulando = false;
        }
        noChao = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.9f, 0.1f), 0f, layerPulavel);
        //fim pulo variavel comando



    }

    private void FixedUpdate()
    {
        // pulo variavel movimento
        if (pulando)
        {
            if (countPulo > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, speedPulo);
            }
            else pulando = false;
        }
        // fim pulo variavel movimento

        //movimento horizontal
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        //fim movimento horizontal

    }
}
