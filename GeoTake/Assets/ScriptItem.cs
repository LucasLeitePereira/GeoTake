using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptItem : MonoBehaviour
{
    public Transform jogador; // Refer�ncia ao Transform do jogador
    public float distanciaSeguranca = 5f; // Dist�ncia m�nima do jogador
    public float velocidade = 2f; // Velocidade de afastamento

    public Transform jogador; // Refer�ncia ao Transform do jogador
    public float distanciaSeguranca = 5f; // Dist�ncia m�nima do jogador
    private NavMeshAgent agente; // Componente NavMeshAgent

    void Start()
    {
        agente = GetComponent<NavMeshAgent>(); // Obt�m o componente NavMeshAgent
    }

    void Update()
    {
        // Verifica a dist�ncia entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, jogador.position);

        // Se o jogador estiver mais perto do que a dist�ncia de seguran�a
        if (distancia < distanciaSeguranca)
        {
            // Calcula a dire��o oposta ao jogador
            Vector3 direcao = (transform.position - jogador.position).normalized;

            // Define o novo destino para o agente
            Vector3 novoDestino = transform.position + direcao * distanciaSeguranca;
            agente.SetDestination(novoDestino);
        }
    }
}
