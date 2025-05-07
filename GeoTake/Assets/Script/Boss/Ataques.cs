
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Xml.Schema;
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
    private bool opcao1 = false;
    private bool opcao2 = false;
    private bool opcao3 = false;
    private bool opcao4 = false;
    private bool opcao5 = false;
    private bool encerrar = false;
    
    void Start()
    {
        icon = Icon.ic;
         movimentacaoCerta = movim1.GetComponent<MovimentacaoPlayers>();
         movimentacaoInvertida = movim2.GetComponent<MovimentoInvertido>();
            
    }
    void Update()
    {
        
            int cont = Mathf.RoundToInt(Time.time);
            Debug.Log(cont);
        
        if (cont %5 == 0 && rodando == false && cont != 0 && cont % 15 != 0)
        {
            random = Random.Range(1, 6);
            Debug.Log("Opcão " + random);
            Evento();
            rodando = true;
        }
        if(cont % 15 == 0 && encerrar == true )
        {
            EncerrarEvento();
        }
    }
    public void Evento()
    {
        switch (random)
        {
            case 1:
                Debug.Log("Opcão " + random);
                Opcao1();
                break;
            case 2:
                Debug.Log("Opcão " + random);
                Opcao2();
                break;
            case 3:
                Debug.Log("Opcão " + random);
                Opcao3();
                break;
            case 4:
                Debug.Log("Opcão " + random);
                Opcao4();
                break;
            case 5:
                Debug.Log("Opcão " + random);
                Opcao5();
                break;
        }
        encerrar = true;
    }
public void Opcao1()
    {
        obs.SetActive(true);
            nuvem.SetActive(true);
                imagems[3].SetActive(true);
                    imagems[1].SetActive(true);
                        opcao1 = true;
                            random = 0;
    }
public void Opcao2(){
        nuvem.SetActive(true);
            obs2.SetActive(true);
                imagems[0].SetActive(true);
                    imagems[3].SetActive(true);
                        obs.SetActive(true);
                            opcao2 = true;
                                random = 0;
    }
public void Opcao3(){
    obs2.SetActive(true);
        imagems[0].SetActive(true);
            imagems[2].SetActive(true);
                movimentacaoCerta.enabled = false;
                    movimentacaoInvertida.enabled = true;
                        opcao3 = true;
                            random = 0;
    }
public void Opcao4(){
    obs.SetActive(true);
        imagems[1].SetActive(true);
         imagems[2].SetActive(true);
             movimentacaoCerta.enabled = false;
                movimentacaoInvertida.enabled = true;
                    opcao4 = true;
                        random = 0;
    }
public void Opcao5(){
    obs.SetActive(true);
        nuvem.SetActive(true);
            imagems[1].SetActive(true);
                imagems[3].SetActive(true);
                    opcao5 = true;
                        random = 0;
    }
    public void EncerrarEvento()
    {
       
       
        if (opcao1 == true)
        {

           
            nuvem.SetActive(false);
            obs.SetActive(false);
            opcao1 = false;
        }
        else if(opcao2 == true)
        {
            obs2.SetActive(false);
            nuvem.SetActive(false);
            obs.SetActive(false);
            opcao2 = false;
        }
        else if (opcao3 == true)
        {
            obs2.SetActive(false);
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            opcao3 = false;
        }
        else if (opcao4 == true)
        {
            movimentacaoCerta.enabled = true;
            movimentacaoInvertida.enabled = false;
            obs.SetActive(false);
            opcao4 = false;
        }
        else if (opcao5 == true)
        {
            nuvem.SetActive(false);
            obs.SetActive(false);
            opcao5 = false;
        }
         
        encerrar = false;
        rodando = false;

    }
}

