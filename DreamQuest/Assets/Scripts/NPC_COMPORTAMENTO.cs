using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_COMPORTAMENTO : MonoBehaviour
{
    public bool tocandoPlayer;
    public bool interativoCriado;
    public bool interativoUsado;
    public GameObject interativo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //apertar botao para interagir
        if (Input.GetKeyDown("f"))
        {
            if (interativoCriado)
            {
                Object.Destroy(this.gameObject.transform.GetChild(0).gameObject);
                Debug.Log("CONVERSA COMEÇA");
                interativoUsado = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ve se o jogador esta perto para interagir com NPC, cria bloco acima do npc
        if (collision.tag == "Player")
        {
            tocandoPlayer = true;

            if (!interativoCriado)
            {
                Instantiate(interativo,
                    new Vector2(transform.position.x, transform.position.y + 1)
                    , this.gameObject.transform.rotation
                    , this.gameObject.transform);
                interativoCriado = true;
                interativoUsado = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //ve se jogador saiu de perto do NPC destroy caixa de interação se nao foi destruida pelo jogador apertando "F"
        if (collision.tag == "Player")
        {
            tocandoPlayer = false;
            if (!interativoUsado)
            {
                Object.Destroy(this.gameObject.transform.GetChild(0).gameObject);
            }
            
            interativoCriado = false;
        }
    }
}