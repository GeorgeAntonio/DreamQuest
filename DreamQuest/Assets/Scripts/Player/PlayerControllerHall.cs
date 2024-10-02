using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHall : MonoBehaviour
{
    public float speed = 5.0f; // Velocidade de movimento do personagem
    public float jumpForce = 10.0f; // Força do pulo
    private Rigidbody2D rb;
    private bool isGrounded; // Verifica se o personagem está tocando o chão

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do personagem
    }

    void Update()
    {
        Move();
        Jump();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Obtém entrada do teclado (esquerda/direita)
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); // Move o personagem horizontalmente
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Adiciona força vertical para o pulo
        }
    }

    void Interact()
    {
        Debug.Log("Interagindo"); // Aqui você pode adicionar o código de interação
    }

    // Verifica colisão com o chão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
