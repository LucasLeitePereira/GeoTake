using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perseguir1 : MonoBehaviour
{
  public Transform jogador1; // Refer�ncia ao jogador 1
   
    public NavMeshAgent agente; // O NavMeshAgent do inimigo

   


void Start()
    {
      
    }

    void Update()
    {
      if (agente.velocity.sqrMagnitude > 0.1f) // se estiver se movendo
    {
        Quaternion targetRotation = Quaternion.LookRotation(agente.velocity.normalized);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f); // suavidade ajustável
    }
   
     agente.SetDestination(jogador1.position);



    }
}
