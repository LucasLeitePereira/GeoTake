using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PerseguirPlayer : MonoBehaviour
{
    public GameObject jogador1; 
    public GameObject jogador2; 
    public NavMeshAgent agente; 

    void Update()
    {
       
        if (jogador1.activeSelf && jogador2.activeSelf)
        {
            float distanciaJogador1 = Vector3.Distance(transform.position, jogador1.transform.position);
            float distanciaJogador2 = Vector3.Distance(transform.position, jogador2.transform.position);

            GameObject jogadorMaisProximo;

            if (distanciaJogador1 < distanciaJogador2)
            {
                jogadorMaisProximo = jogador1;
            }
            else
            {
                jogadorMaisProximo = jogador2;
            }

            agente.SetDestination(jogadorMaisProximo.transform.position);
        }
        else if (jogador1.activeSelf  && !jogador2.activeSelf)
        {
            agente.SetDestination(jogador1.transform.position);
        }
      
    }
}
