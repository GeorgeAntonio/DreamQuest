using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista_Magia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LerMagia(int fogo, int agua, int terra)
    {
        int ler = (fogo * 100) + (agua * 10) + (terra);

        switch (ler)
        {
            case 300:
                //magia 3 fogos
                break;
            case 30:
                //magia 3 agua
                break;
            case 3:
                //magia 3 tera
                break;
            case 210:
                //magia 2 fogo 1 agua
                break;
            case 201:
                //magia 2 fogo 1 terra
                break;
            case 120:
                //magia 1 fogo 2 agua
                break;
            case 21:
                //magia 2 agua 1 terra
                break;
            case 102:
                //magia 1 fogo 2 terra
                break;
            case 12:
                //magia 1 agua 2 terra
                break;
            case 111:
                //magia 1 fogo 1 agua 1 terra
                break;

        }
    }
}
