using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Velocidade de movimento do personagem
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do personagem
    }

    void Update()
    {
        // Obtém entrada do teclado (cima, baixo, esquerda, direita)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized; // Normaliza o vetor de movimento para manter a velocidade constante em todas as direções

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void FixedUpdate()
    {
        // Move o personagem
        rb.velocity = moveInput * speed;
    }

    void Interact()
    {
        // Adicione aqui a lógica de interação
        Debug.Log("Interacting");
    }
}
