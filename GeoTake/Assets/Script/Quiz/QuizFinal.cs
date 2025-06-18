using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizFinal : MonoBehaviour
{
    public GameObject resultados;
    public TMP_Text cabecalho;
    public Button[] alternativa;
    public Quiz[] quantidade;
    public int index = 0;
    public string cena;
    void Start()
    {
        MostrarQuiz();
    }

    public void MostrarQuiz()
    {

        Quiz p = quantidade[index];
        cabecalho.text = p.perguntaTexto;
        for (int i = 0; i < alternativa.Length; i++)
        {
            alternativa[i].GetComponentInChildren<TextMeshProUGUI>().text = p.alternativasTexto[i];

            int possibilidade = i;
            alternativa[i].onClick.RemoveAllListeners();
            alternativa[i].onClick.AddListener(() => verificar(possibilidade));
        }
    }
    public void verificar(int possibilidade)
    {
        Quiz p = quantidade[index];
        if (possibilidade == p.indexCorreto)
        {
            Debug.Log("CORRETO");
        }
        else
        {
            Debug.Log("Errado");
        }

        ++index;
        if (index < 4)
        {
            MostrarQuiz();
        }
        else
        {
            resultados.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }
   
}
