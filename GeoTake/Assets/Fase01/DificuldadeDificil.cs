using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificuldadeDificil : MonoBehaviour
{
    public GameController game;
    public ScriptModoDificil tempoItem;

    private void Start()
    {
        game = GameController.gc;
        tempoItem = ScriptModoDificil.tmpItem;

        game.timeCount = 40;

        // Obtém a cena atual
        string nomeCena = SceneManager.GetActiveScene().name;

        if (String.Compare("Fase01", nomeCena) == 0)
        {
            // Imprime o nome da cena no console
            Debug.Log("Nome da cena atual: " + nomeCena);
        }
        
        if (String.Compare("Fase02", nomeCena) == 0)
        {
            Debug.Log("Nome da cena atual: " + nomeCena);
            tempoItem.tempoAtivo = 1f;
            tempoItem.tempoInvisivel = 1f;   // Intervalo entre itens
        }
    }
}
