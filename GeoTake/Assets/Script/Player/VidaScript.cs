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
        if (other.gameObject.tag == "Inimigos")
        {
            if (game.vidas >= 0)
            {
                game.vidas--;
                Debug.Log("-1 Vida!");
                Debug.Log("Vidas restantes: " + game.vidas);

                game.vidaText.text = game.vidas.ToString(); // Altera a quantidade de vidas na tela
                transform.position = positionInitial; // Volta o player para o ponto Inicial

                if (game.vidas <= 0)
                {
                    game.vidas = 0;
                    game.alive = false;
                    Debug.Log("Morreu!");
                } 
            }
        }
    }

}
