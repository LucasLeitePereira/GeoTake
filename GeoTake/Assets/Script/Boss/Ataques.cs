using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataques : MonoBehaviour
{
    public GameObject obs2;
    public GameObject obs;
    public GameObject movim1;
    public GameObject movim2;
    private int contador;

    public MonoBehaviour movimentacaoCerta; 
    public MonoBehaviour movimentacaoInvertida; 
    void Start()
    {
         movimentacaoCerta = movim1.GetComponent<MovimentacaoPlayers>();
         movimentacaoInvertida = movim2.GetComponent<MovimentoInvertido>();


    }

    // Update is called once per frame
    void Update()
    {
        
         contador += Mathf.CeilToInt(Time.deltaTime * 1);
        Debug.Log(contador);
        if(contador ==1000){
               Debug.Log("Terreno Ativado");

               
                 obs.SetActive(true);
               
            
           
        }
        if(contador ==3000){
               Debug.Log("Terreno Desativado");
            
                 obs.SetActive(false);
               
        
        }
        if(contador ==3500){
               Debug.Log("Familia Ativado");
            
                 obs2.SetActive(true);
               
           
        }
            if(contador ==7000){
                Debug.Log("familia Desativado");
           
                 obs2.SetActive(false);
               
               
        }
        if (contador == 7500)
        {
            Debug.Log("inverte Ativado");
            movimentacaoCerta.enabled = false;
            movimentacaoInvertida.enabled = true;


        }
        if (contador == 13500)
        {
            Debug.Log("inverte Desativado");

            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            contador = 0;
            Time.timeScale = 1;

        }

    }
}
