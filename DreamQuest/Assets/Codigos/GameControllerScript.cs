using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public static GameControllerScript instance = null;
    // Start is called before the first frame update
    void Start()
    {
        //se ja criou o gamecontroller destrua o clone
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //fim
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NovaFase()
    {
        //se ta na fase 0 vai pra 1 se ta na fase 1 vai para 0
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(1);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(0);
        }
        //fim
    }
}
