using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript : MonoBehaviour
{
    public static VidaScript vs;

    public GameController game;

    private Vector3 positionInitial;

    private void Awake()
    {
        if (vs == null)
        {
            vs = this;
        }
    }

    private void Start()
    {
        positionInitial = transform.position;
        game = GameController.gc;
    }

    private void OnCollisionEnter(Collision other)
    {
        // Verificar se o objeto colidido é um inimigo
        if (other.gameObject.CompareTag("Inimigos"))
        {
            // Só realiza a lógica se o jogador tiver vidas restantes
            if (game.vidas > 0)
            {
                // Subtrai uma vida
                game.vidas--;
                Debug.Log("-1 Vida!");
                Debug.Log("Vidas restantes: " + game.vidas);
                MusicManager.instancia.TocarSomDano();

                // Atualiza o texto na tela
                game.vidaText.text = game.vidas.ToString();

                // Reinicia a posição do jogador
                transform.position = positionInitial;

                // Verifica se as vidas acabaram
                if (game.vidas <= 0)
                {
                    game.vidas = 0;
                    game.alive = false;
                    Debug.Log("Morreu!");
                    

                    // Aqui você pode chamar um método de Game Over ou reiniciar a cena
                    // Exemplo: GameOver();
                }
            }
        }
    }

    // Método para reiniciar o personagem caso precise em outro lugar do código
    public void ReiniciarVida()
    {
        // Reinicia o número de vidas, o estado do jogador, etc.
        game.vidas = 3; // Exemplo, dependendo do seu sistema de vidas
        game.alive = true;
        transform.position = positionInitial; // Reinicia a posição
    }
}
