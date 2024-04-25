using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento_Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject alvo;
    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player");
        Vector3 direction = alvo.transform.position - this.transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (direction.x, direction.y);
        Invoke("Destruir", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
