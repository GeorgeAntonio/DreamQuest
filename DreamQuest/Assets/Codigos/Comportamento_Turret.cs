using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento_Turret : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alvo;
    public GameObject bullet;
    public GameObject mira;

    public bool recarga = true;
    void Start()
    {

        alvo = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (alvo != null)
        {
            transform.up = new Vector2(alvo.transform.position.x - this.transform.position.x, alvo.transform.position.y - this.transform.position.y);


            if (Vector2.Distance(alvo.transform.position, this.transform.position) <= 10f && recarga)
            {
                Invoke("Atirar", 5f);
                recarga = false;
            }
        }
    }

    private void Atirar()
    {
        Instantiate(bullet, mira.transform.position, this.transform.rotation);
        recarga=true;
    }
}
