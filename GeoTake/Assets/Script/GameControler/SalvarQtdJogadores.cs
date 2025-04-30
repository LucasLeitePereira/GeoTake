using UnityEngine;
using UnityEngine.UI;

public class SalvarQtdJogadores : MonoBehaviour
{
    [SerializeField] private Button botaoUmJogador;
    [SerializeField] private Button botaoDoisJogadores;


    // Chave para PlayerPrefs
    private const string CHAVE_NUMERO_JOGADORES = "NumeroDeJogadores";

    void Start()
    {
        // Adicionar listeners aos botões existentes
        if (botaoUmJogador != null)
        {
            botaoUmJogador.onClick.AddListener(SelecionarUmJogador);
            Debug.Log("Botão de 1 jogador conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Botão de 1 jogador não foi atribuído no Inspector!");
        }

        if (botaoDoisJogadores != null)
        {
            botaoDoisJogadores.onClick.AddListener(SelecionarDoisJogadores);
            Debug.Log("Botão de 2 jogadores conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Botão de 2 jogadores não foi atribuído no Inspector!");
        }

        // Carregar e mostrar a opção salva anteriormente
        AtualizarInterface();
    }

    public void SelecionarUmJogador()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_NUMERO_JOGADORES, 1);

        // Log de confirmação
        Debug.Log("OPÇÃO SALVA: 1 jogador foi selecionado e salvo com sucesso!");

        // Atualizar interface
        AtualizarInterface();
    }

    public void SelecionarDoisJogadores()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_NUMERO_JOGADORES, 2);

        // Log de confirmação
        Debug.Log("OPÇÃO SALVA: 2 jogadores foram selecionados e salvos com sucesso!");

        // Atualizar interface
        AtualizarInterface();
    }

    private void AtualizarInterface()
    {
        // Carregar a preferência salva (padrão: 1 jogador)
        int numeroJogadores = PlayerPrefs.GetInt(CHAVE_NUMERO_JOGADORES, 1);

        // Log para confirmar que a preferência foi carregada corretamente
        Debug.Log("OPÇÃO CARREGADA: Número de jogadores configurado para: " + numeroJogadores);

    }

    // Para usar em outras cenas/scripts
    public static int ObterNumeroJogadores()
    {
        int numeroJogadores = PlayerPrefs.GetInt(CHAVE_NUMERO_JOGADORES, 1);
        Debug.Log("CONFIGURAÇÃO OBTIDA: Número de jogadores configurado para: " + numeroJogadores);
        return numeroJogadores;
    }
}