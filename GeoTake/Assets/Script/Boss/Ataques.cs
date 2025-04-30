
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataques : MonoBehaviour
{
    public GameObject obs2;
    public GameObject obs;
    public GameObject movim1;
    public GameObject movim2;
   
    public GameObject nuvem;
    private int random = 0;
    public MonoBehaviour movimentacaoCerta; 
    public MonoBehaviour movimentacaoInvertida; 
    public GameObject[] imagems;
    private float cont = 0;
    private bool rodando = false;
    void Start()
    {
         movimentacaoCerta = movim1.GetComponent<MovimentacaoPlayers>();
         movimentacaoInvertida = movim2.GetComponent<MovimentoInvertido>();


    }

    // Update is called once per frame
    void Update()
    {

        int cont = Mathf.RoundToInt(Time.time);
        Debug.Log(cont);

        if(cont == 10  && rodando == false ){
            random = Random.Range(1,6);
               Debug.Log("Opcão " + random);
            rodando=true;
}
        if(random == 1   ){
               Debug.Log("Opcão " + random);
            Opcao1();
                 }

        if(random ==2 )
        {
               Debug.Log("Opcão " + random);
            Opcao2();
                 }

        if(random ==3)
        {
               Debug.Log("Opcão " + random);
            Opcao3();
                 }

        if(random ==4 )
        {
               Debug.Log("Opcão " + random);
            Opcao4();
                 }

        if(random ==5 )
        {
               Debug.Log("Opcão " + random);
            Opcao5();
                 }
    
}
    public void Opcao1()
    {
        obs.SetActive(true);
        nuvem.SetActive(true);
        imagems[3].SetActive(true);
        imagems[1].SetActive(true);

        if (cont ==20)
        {
       
            
            nuvem.SetActive(false);
                imagems[3].SetActive(false);
                imagems[1].SetActive(true);
                obs.SetActive(false);
            cont = 0;
                Time.timeScale = 1;
                random = 0;
            rodando = false;

        }
    }
public void Opcao2(){
        nuvem.SetActive(true);
        obs2.SetActive(true);
        imagems[0].SetActive(true);
        imagems[3].SetActive(true);
    obs.SetActive(true);
    if(cont == 20){
        obs2.SetActive(false);
        imagems[0].SetActive(false);
        nuvem.SetActive(false);
        imagems[3].SetActive(false);
        cont =0;
        Time.timeScale = 1;
        random = 0;
            rodando = false;
        }
}

public void Opcao3(){
    obs2.SetActive(true);
    imagems[0].SetActive(true);
    imagems[2].SetActive(true);
   movimentacaoCerta.enabled = false;
        movimentacaoInvertida.enabled = true;
    if(cont == 20){
        obs2.SetActive(false);
        imagems[0].SetActive(false);
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
             imagems[2].SetActive(false);
            cont =0;
        Time.timeScale = 1;
        random = 0;
            rodando = false;
        }
}

public void Opcao4(){
   
    obs.SetActive(true);
    imagems[1].SetActive(true);
    imagems[2].SetActive(true);
        movimentacaoCerta.enabled = false;
        movimentacaoInvertida.enabled = true;
        if (cont == 20){
            imagems[2].SetActive(false);
            imagems[1].SetActive(false);
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            obs.SetActive(false);
        cont =0;
        Time.timeScale = 1;
        random = 0;
            rodando = false;
        }
}

public void Opcao5(){
    obs.SetActive(true);
    nuvem.SetActive(true);
   imagems[1].SetActive(true);
   imagems[3].SetActive(true);
    if(cont ==20){
       imagems[1].SetActive(false);
       imagems[3].SetActive(false);
        nuvem.SetActive(false);
        obs.SetActive(false);
        cont = 0;
        Time.timeScale = 1;
        random = 0;
            rodando = false;
        }
}
}
