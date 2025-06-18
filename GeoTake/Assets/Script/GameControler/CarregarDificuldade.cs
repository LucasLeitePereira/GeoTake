using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregarDificuldade : MonoBehaviour
{
    public GameObject facil;
    public GameObject medio;
    public GameObject dificil;

    public GameObject tempoItem;
    
    // Start is called before the first frame update
    void Start()
    {
        int DificuldadeSelecionada = SalvarDificuldade.ObterDificuldade();
    
        facil.SetActive(false);
        medio.SetActive(false);
        dificil.SetActive(false);
        tempoItem.SetActive(false);

        if (DificuldadeSelecionada == 1)
        {
            facil.SetActive(true);
        } else if (DificuldadeSelecionada == 2)
        {
            medio.SetActive(true);
        } else
        {
            dificil.SetActive(true);
        }

        if (DificuldadeSelecionada > 1)
        {
            tempoItem.SetActive(true);
        }
    }

    
}
