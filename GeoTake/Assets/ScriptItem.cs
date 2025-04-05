using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptItem : MonoBehaviour
{
    public Transform jogador; // Referência ao Transform do jogador
    public float distanciaSeguranca = 5f; // Distância mínima do jogador
    public float velocidade = 2f; // Velocidade de afastamento

    public Transform jogador; // Referência ao Transform do jogador
    public float distanciaSeguranca = 5f; // Distância mínima do jogador
    private NavMeshAgent agente; // Componente NavMeshAgent

    void Start()
    {
        agente = GetComponent<NavMeshAgent>(); // Obtém o componente NavMeshAgent
    }

    void Update()
    {
        // Verifica a distância entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, jogador.position);

        // Se o jogador estiver mais perto do que a distância de segurança
        if (distancia < distanciaSeguranca)
        {
            // Calcula a direção oposta ao jogador
            Vector3 direcao = (transform.position - jogador.position).normalized;

            // Define o novo destino para o agente
            Vector3 novoDestino = transform.position + direcao * distanciaSeguranca;
            agente.SetDestination(novoDestino);
        }
    }
}
