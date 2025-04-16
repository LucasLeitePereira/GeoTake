using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptModoDificil : MonoBehaviour
{
    public GameObject[] Lista;          // Itens que podem aparecer
    public float tempoInvisivel = 2f;   // Tempo entre um item desaparecer e o pr�ximo aparecer
    public float tempoAtivo = 1f;       // Tempo que o item fica vis�vel

    private bool itemAtivo = false;     // Controla se h� um item ativo no momento

    private void Start()
    {
        StartCoroutine(CicloItens()); // Inicia o ciclo eterno
    }

    IEnumerator CicloItens()
    {
        while (true) // Loop infinito
        {
            // Escolhe um item aleat�rio
            int numItem = Random.Range(0, Lista.Length);
            GameObject item = Lista[numItem];

            // Ativa o item
            item.SetActive(true);
            Debug.Log(item.name + " Ativado");
            itemAtivo = true;

            // Espera o tempo que o item fica vis�vel
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