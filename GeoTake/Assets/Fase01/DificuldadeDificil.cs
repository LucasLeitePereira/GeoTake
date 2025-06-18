using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificuldadeDificil : MonoBehaviour
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

        game.timeCount = 40;

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
            tempoItem.tempoAtivo = 3f;
            tempoItem.tempoInvisivel = 2f; // Intervalo entre itens

   
        }

        if (String.Compare("Boss", nomeCena) == 0)
        {

        }
    }
}
