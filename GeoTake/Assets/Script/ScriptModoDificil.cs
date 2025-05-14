using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptModoDificil : MonoBehaviour
{
    public GameObject[] Lista;          // Itens pré-configurados no Inspector
    public float tempoInvisivel = 2f;   // Intervalo entre itens
    public float tempoAtivo = 1f;       // Tempo que o item fica visível

    private List<GameObject> itensDisponiveis = new List<GameObject>(); // Itens que ainda não foram coletados
    private Coroutine cicloCorrotina;   // Referência da corrotina

    private void Start()
    {
        // Inicializa a lista de itens disponíveis com os objetos da Lista
        itensDisponiveis.AddRange(Lista);

        // Inicia o ciclo de aparecimento
        cicloCorrotina = StartCoroutine(CicloItens());
    }

    IEnumerator CicloItens()
    {
        while (true)
        {
            // Só continua se houver itens disponíveis
            if (itensDisponiveis.Count == 0)
            {
                Debug.Log("Todos os itens foram coletados!");
                yield break; // Encerra a corrotina
            }

            // Escolhe um item aleatório da lista de disponíveis
            int index = Random.Range(0, itensDisponiveis.Count);
            GameObject item = itensDisponiveis[index];

            // Ativa o item se ele ainda existir na cena
            if (item != null)
            {
                item.SetActive(true);
                Debug.Log(item.name + " ativado.");

                yield return new WaitForSeconds(tempoAtivo); // Tempo visível

                // Desativa o item (se ainda existir)
                if (item != null)
                {
                    item.SetActive(false);
                    Debug.Log(item.name + " desativado.");
                }
            }
            else
            {
                // Remove itens nulos (destruídos) da lista
                itensDisponiveis.RemoveAt(index);
            }

            yield return new WaitForSeconds(tempoInvisivel); // Tempo invisível
        }
    }

    // Método para remover um item destruído da lista
    public void RemoverItemDestruido(GameObject item)
    {
        if (itensDisponiveis.Contains(item))
        {
            itensDisponiveis.Remove(item);
            Debug.Log(item.name + " removido da lista.");
        }
    }
}