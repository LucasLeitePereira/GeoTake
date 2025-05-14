using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFases : MonoBehaviour
{
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private string CarregarJogo;
    [SerializeField] private GameObject TelaPerdeu;
    [SerializeField] private GameObject TelaGanhou;

    string currentScene;
    public void Start()
    {
        // Obtém o nome da cena atual
        currentScene = SceneManager.GetActiveScene().name;

    }

    public void ReiniciarLevel()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void CarregarProximaFase()
    {
        SceneManager.LoadScene(CarregarJogo);
    }

    public void CarreagarQuiz()
    {
 
    }


    public void AbrirOpcoes()
    {
        TelaGanhou.SetActive(false);
        TelaPerdeu.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
    }

    public void Sair()
    {
        Debug.Log("Saindo do Jogo");
        Application.Quit();
    }

    public void VoltarParaMenu()
    {
        SceneManager.LoadScene("Tela de Menu"); // Certifique-se de que a cena tem esse nome no Build Settings
    }


    public void AbrirOpcoesPerdeu()
    {
        TelaPerdeu.SetActive(false);

    }




}

