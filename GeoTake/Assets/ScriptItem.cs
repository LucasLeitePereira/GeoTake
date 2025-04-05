using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ScriptItem : MonoBehaviour
{
    public Transform jogador; // Referência ao Transform do jogador
    public float distanciaSeguranca = 5f; // Distância mínima do jogador
    public float distanciaMaxima = 10f; // Distância máxima que o objeto pode se afastar
    public NavMeshAgent agente; // Componente NavMeshAgent

    void Start()
    {
        agente = GetComponent<NavMeshAgent>(); // Obtém o componente NavMeshAgent

        if (agente == null)
        {
            Debug.LogError("NavMeshAgent não encontrado no objeto " + gameObject.name);
        }
    }

    void Update()
    {
        if (agente == null) return;
        // Verifica a distância entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, jogador.position);

        // Se o jogador estiver mais perto do que a distância de segurança
        if (distancia < distanciaSeguranca)
        {
            // Calcula a direção oposta ao jogador
            Vector3 direcao = (transform.position - jogador.position).normalized;

            // Define o novo destino para o agente
            Vector3 novoDestino = transform.position + direcao * distanciaMaxima;

            // Verifica se o novo destino está dentro do NavMesh
            NavMeshHit hit;
            if (NavMesh.SamplePosition(novoDestino, out hit, 1.0f, NavMesh.AllAreas))
            {
                // Define o destino do agente
                agente.SetDestination(hit.position);
            }
        }
        else
        {
            // Para o agente se o jogador estiver longe o suficiente
            agente.ResetPath();
        }
    }
}
