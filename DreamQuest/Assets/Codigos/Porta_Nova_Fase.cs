using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_Nova_Fase : MonoBehaviour
{
    public bool tocando;
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        //comando para usar a porta
        if (Input.GetKeyDown("f"))
        {
            if (tocando)
            {
                gameController.GetComponent<GameControllerScript>().NovaFase();
            }
        }
        //fim comando para usar a porta
    }

    //conferir se esta na range para abrir a porta
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            tocando = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            tocando = false;
        }
    }
    //fim da conferencia da range para usar a porta
}
