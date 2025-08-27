using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class QuizMensager : MonoBehaviour
{


    public TMP_Text cabecalho;
    public Button[] alternativa;
    public Quiz[] quantidade;
    public Button botaoProxima;
    public GameObject painelFinal;
    public TMP_Text textoResultado;
    public int index = 0;
    public static int acertosTotais = 0;
    public string cena;

    private Color corOriginal;
    public int acertos = 0;


    
    void Start()
    {
        index = 0;
       
        corOriginal = alternativa[0].GetComponent<Image>().color;
        botaoProxima.gameObject.SetActive(false);
        MostrarQuiz();
    }

    public void MostrarQuiz()
    {
        Quiz p = quantidade[index];
        cabecalho.text = p.perguntaTexto;
        botaoProxima.gameObject.SetActive(false);

        for (int i = 0; i < alternativa.Length; i++)
        {
            alternativa[i].interactable = true;
            alternativa[i].GetComponent<Image>().color = corOriginal;
            alternativa[i].GetComponentInChildren<TextMeshProUGUI>().text = p.alternativasTexto[i];

            int possibilidade = i;
            alternativa[i].onClick.RemoveAllListeners();
            alternativa[i].onClick.AddListener(() => verificar(possibilidade));
        }

        botaoProxima.onClick.RemoveAllListeners();
        botaoProxima.onClick.AddListener(ProximaPergunta);
    }

    public void verificar(int possibilidade)
    {
        foreach (var btn in alternativa)
            btn.interactable = false;

        Quiz p = quantidade[index];

        for (int i = 0; i < alternativa.Length; i++)
        {
            Image img = alternativa[i].GetComponent<Image>();
            if (i == p.indexCorreto)
                img.color = Color.green;
            else if (i == possibilidade)
                img.color = Color.red;
            else
                img.color = Color.red;
        }
        if (possibilidade == p.indexCorreto)
        {
            acertos++;
            acertosTotais++;
        }


        botaoProxima.gameObject.SetActive(true);
    }

    public void ProximaPergunta()
    {
        index++;
        if (index < quantidade.Length)
        {
           
            MostrarQuiz();
        }
        else
        {
            botaoProxima.gameObject.SetActive(false);
            SceneManager.LoadScene(cena);
            MostrarResultadoFinal();
        }
    }

    void MostrarResultadoFinal()
    {
        painelFinal.SetActive(true);
        textoResultado.text = $"Você acertou {acertosTotais} de 15 perguntas!";
    }
}
