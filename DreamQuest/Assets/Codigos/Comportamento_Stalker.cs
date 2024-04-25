using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento_Stalker: MonoBehaviour
{
    public GameObject alvo;
    public float centroy;
    public Rigidbody2D rb;
    public float speedX, speedY;
    // Start is called before the first frame update
    void Start()
    {
        //encontrando o Player para ter como alvo
        alvo = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(alvo != null)
        {
            if(this.transform.position.x > alvo.transform.position.x)
            {
                speedX = -2f;
            }
            if(this.transform.position.y > alvo.transform.position.y)
            {
                speedY = -2f;
            }
            if (this.transform.position.x < alvo.transform.position.x)
            {
                speedX = 2f;
            }
            if (this.transform.position.y < alvo.transform.position.y)
            {
                speedY = 2f; 
            }

            if(this.transform.position.y - alvo.transform.position.y <= 0.1f && this.transform.position.y - alvo.transform.position.y >= -0.1f)
            {
                speedY = 0;
            }

            if (this.transform.position.x - alvo.transform.position.x <= 0.5f && this.transform.position.x - alvo.transform.position.x >=  -0.5f)
            {
                speedX = 0;
            }
            rb.velocity = new Vector2(speedX, speedY);
        }
    }
}
