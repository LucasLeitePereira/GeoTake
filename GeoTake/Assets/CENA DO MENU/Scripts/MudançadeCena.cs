using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudançadeCena : MonoBehaviour
{
    [SerializeField] private string CenaJogar;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject SelectPlayer;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject SelectDificuldade;
    [SerializeField] private string CarregarJogo;
    [SerializeField] private GameObject TelaPerdeu;
    [SerializeField] private GameObject TelaGanhou;

    string currentScene;

    public static MudançadeCena mc;
    public void Start()
    {
        // Obtém o nome da cena atual
        currentScene = SceneManager.GetActiveScene().name;

        if (mc == null)
        {
            mc = this;
        }

    }
    public void Jogar()
    {
        Debug.Log("Inciando o jogo");
        SceneManager.LoadScene(CenaJogar);
    }

    public void CarregarFase()
    {
        Debug.Log("Inciando o jogo");
        SceneManager.LoadScene(CarregarJogo);
    }

    public void ReiniciarLevel()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
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

    public void AbrirSelectPlayer()
    {
        painelMenuInicial.SetActive(false);
        SelectPlayer.SetActive(true);
    }

    public void AbrirSelectDificuldade()
    {
        SelectPlayer.SetActive(false);
        painelMenuInicial.SetActive(false);
        SelectDificuldade.SetActive(true);
    }

    public void AbrirOpcoesPerdeu()
    {
        TelaPerdeu.SetActive(false);

    }




}

