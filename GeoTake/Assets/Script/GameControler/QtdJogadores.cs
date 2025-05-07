using UnityEngine;

public class GerenciadorJogo : MonoBehaviour
{

    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject Player2;

    void Start()
    {
        int numeroJogadores = SalvarQtdJogadores.ObterNumeroJogadores();
        int DificuldadeSelecionada = SalvarDificuldade.ObterDificuldade();

        // Ou usando a segunda implementação
        // int numeroJogadores = SeletorDeJogadores.ObterNumeroDeJogadores();

        if (numeroJogadores == 1)
        {
            // Configurar para um jogador
            Debug.Log("Iniciando modo um jogador");
            ConfigurarModoUmJogador();
        }
        else
        {
            // Configurar para dois jogadores
            Debug.Log("Iniciando modo dois jogadores");
        }
    }

    private void ConfigurarModoUmJogador()
    {
        Player1.SetActive(false);
    }

}