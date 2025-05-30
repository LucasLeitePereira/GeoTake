using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimentacaoPlayers : MonoBehaviour
{

    public Animator Correr;
    public Mudan�adeCena cena;
    public float moveSpeed = 5f; // Velocidade de movimento
    public float rotationSpeed = 10f; // Velocidade de rota��o

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode pause;

    void Update()
    {
        // Obter entrada do teclado
        float horizontal = Input.GetKey(right) ? 1 : Input.GetKey(left) ? -1 : 0;
        float vertical = Input.GetKey(up) ? 1 : Input.GetKey(down) ? -1 : 0;

        float eixoX = transform.position.x;
        float eixoZ = transform.position.z;
        transform.position = new Vector3(eixoX, 0, eixoZ);

        // Normalizar o vetor para evitar movimento mais r�pido na diagonal
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Movimentar o personagem
        if (moveDirection.magnitude >= 0.1f)
        {
            // Atualizar a posi��o do personagem no espa�o global
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

            // Calcular a rota��o desejada na dire��o do movimento
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);

            // Suavizar a rota��o
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            Correr.SetBool("Correr", true);

        }
      

    }
}
