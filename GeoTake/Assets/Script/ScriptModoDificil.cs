using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptModoDificil : MonoBehaviour
{
    public GameObject[] Lista;          // Itens que podem aparecer
    public float tempoInvisivel = 2f;   // Tempo entre um item desaparecer e o próximo aparecer
    public float tempoAtivo = 1f;       // Tempo que o item fica visível

    private bool itemAtivo = false;     // Controla se há um item ativo no momento

    private void Start()
    {
        StartCoroutine(CicloItens()); // Inicia o ciclo eterno
    }

    IEnumerator CicloItens()
    {
        while (true) // Loop infinito
        {
            // Escolhe um item aleatório
            int numItem = Random.Range(0, Lista.Length);
            GameObject item = Lista[numItem];

            // Ativa o item
            item.SetActive(true);
            Debug.Log(item.name + " Ativado");
            itemAtivo = true;

            // Espera o tempo que o item fica visível
            yield return new WaitForSeconds(tempoAtivo);

            // Desativa o item
            item.SetActive(false);
            Debug.Log(item.name + " Desativado");
            itemAtivo = false;

            // Espera o tempo entre ciclos
            yield return new WaitForSeconds(tempoInvisivel);
        }
    }
}