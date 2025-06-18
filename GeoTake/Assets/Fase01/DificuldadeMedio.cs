using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificuldadeMedio : MonoBehaviour
{
    public GameController game;
    public ScriptModoDificil tempoItem;
    public NewBehaviourScript inimigo;

    public string nomeCena;

    private void Start()
    {
        game = GameController.gc;
        tempoItem = ScriptModoDificil.tmpItem;
        inimigo = NewBehaviourScript.spawnarInimigos;

        game.timeCount = 60;

        nomeCena = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if (String.Compare("Fase01", nomeCena) == 0)
        {
            // Imprime o nome da cena no console
        }

        if (String.Compare("Fase02", nomeCena) == 0)
        {
            tempoItem.tempoAtivo = 5f;
            tempoItem.tempoInvisivel = 2f; // Intervalo entre itens

            if (Math.Abs(inimigo.contador) > 10)
            {
                inimigo.desativarInimigos();
                Debug.Log("Inimigos desativados");
            }
        }

        if (String.Compare("Boss", nomeCena) == 0)
        {
            
        }
    }
}
