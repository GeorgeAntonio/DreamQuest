using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comando_Magias : MonoBehaviour
{
    private Dictionary<string, int> magia = new Dictionary<string, int>();
    private int max = 0;
    // Start is called before the first frame update
    void Start()
    {
        magia["fogo"] = 0;
        magia["agua"] = 0;
        magia["terra"] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            if (max < 3)
            {
                magia["fogo"]++;
                max++;
                Debug.Log("adicionou fogo");
            }
        }

        if (Input.GetKeyDown("2"))
        {
            if (max < 3)
            {
                magia["agua"]++;
                max++;
                Debug.Log("adicionou agua");
            }
        }

        if (Input.GetKeyDown("3"))
        {
            if (max < 3)
            {
                magia["terra"]++;
                max++;
                Debug.Log("adicionou terra");
            }
        }

        if (Input.GetKeyDown("4"))
        {
            if (max >= 3)
            {
                Debug.Log("magia com : " + magia["fogo"] + " fogo && magia com : " + magia["agua"] + " agua && magia com : " + magia["terra"] + " terra");
                magia["fogo"] = 0;
                magia["agua"] = 0;
                magia["Terra"] = 0;
                max = 0;
            }
        }

        if ((Input.GetKeyDown("5")))
        {
            magia["fogo"] = 0;
            magia["agua"] = 0;
            magia["Terra"] = 0;
            max = 0;
        }
    }
}
