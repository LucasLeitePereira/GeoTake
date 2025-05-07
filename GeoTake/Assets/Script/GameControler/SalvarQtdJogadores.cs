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
        // Adicionar listeners aos bot�es existentes
        if (botaoUmJogador != null)
        {
            botaoUmJogador.onClick.AddListener(SelecionarUmJogador);
            Debug.Log("Bot�o de 1 jogador conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Bot�o de 1 jogador n�o foi atribu�do no Inspector!");
        }

        if (botaoDoisJogadores != null)
        {
            botaoDoisJogadores.onClick.AddListener(SelecionarDoisJogadores);
            Debug.Log("Bot�o de 2 jogadores conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Bot�o de 2 jogadores n�o foi atribu�do no Inspector!");
        }

        // Carregar e mostrar a op��o salva anteriormente
        AtualizarInterface();
    }

    public void SelecionarUmJogador()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_NUMERO_JOGADORES, 1);

        // Log de confirma��o
        Debug.Log("OP��O SALVA: 1 jogador foi selecionado e salvo com sucesso!");

        // Atualizar interface
        AtualizarInterface();
    }

    public void SelecionarDoisJogadores()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_NUMERO_JOGADORES, 2);

        // Log de confirma��o
        Debug.Log("OP��O SALVA: 2 jogadores foram selecionados e salvos com sucesso!");

        // Atualizar interface
        AtualizarInterface();
    }

    private void AtualizarInterface()
    {
        // Carregar a prefer�ncia salva (padr�o: 1 jogador)
        int numeroJogadores = PlayerPrefs.GetInt(CHAVE_NUMERO_JOGADORES, 1);

        // Log para confirmar que a prefer�ncia foi carregada corretamente
        Debug.Log("OP��O CARREGADA: N�mero de jogadores configurado para: " + numeroJogadores);

    }

    // Para usar em outras cenas/scripts
    public static int ObterNumeroJogadores()
    {
        int numeroJogadores = PlayerPrefs.GetInt(CHAVE_NUMERO_JOGADORES, 1);
        Debug.Log("CONFIGURA��O OBTIDA: N�mero de jogadores configurado para: " + numeroJogadores);
        return numeroJogadores;
    }
}