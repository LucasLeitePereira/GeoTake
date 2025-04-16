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
    public GameObject nuvem;
    private int random = 0;
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
        
         contador += Mathf.CeilToInt(Time.deltaTime );
       
        if(contador ==700){
            random = Random.Range(1,6);
               Debug.Log("Opcão " + random);
}
        if(random ==1){
               Debug.Log("Opcão " + random);
            Opcao1();
                 }

        if(random ==2){
               Debug.Log("Opcão " + random);
            Opcao2();
                 }

        if(random ==3){
               Debug.Log("Opcão " + random);
            Opcao3();
                 }

        if(random ==4){
               Debug.Log("Opcão " + random);
            Opcao4();
                 }

        if(random ==5){
               Debug.Log("Opcão " + random);
            Opcao5();
                 }
    
}
public void Opcao1(){
    obs2.SetActive(true);
        nuvem.SetActive(true);
        if (contador == 2000){
            nuvem.SetActive(false);
            obs2.SetActive(false);
        contador =0;
        Time.timeScale = 1;
        random = 0;
    }
}

public void Opcao2(){
        nuvem.SetActive(true);
        obs2.SetActive(true);
    obs.SetActive(true);
    if(contador == 2000){
        obs2.SetActive(false);
        obs.SetActive(false);
            nuvem.SetActive(false);
            contador =0;
        Time.timeScale = 1;
        random = 0;
    }
}

public void Opcao3(){
    obs2.SetActive(true);
   movimentacaoCerta.enabled = false;
        movimentacaoInvertida.enabled = true;
    if(contador == 2000){
        obs2.SetActive(false);
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            contador =0;
        Time.timeScale = 1;
        random = 0;
    }
}

public void Opcao4(){
   
    obs.SetActive(true);
        movimentacaoCerta.enabled = false;
        movimentacaoInvertida.enabled = true;
        if (contador == 2000){
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            obs.SetActive(false);
        contador =0;
        Time.timeScale = 1;
        random = 0;
    }
}

public void Opcao5(){
    obs.SetActive(true);
    nuvem.SetActive(true);
   
    if(contador == 2000){
       
        nuvem.SetActive(false);
        obs.SetActive(false);
        contador =0;
        Time.timeScale = 1;
        random = 0;
    }
}
}
