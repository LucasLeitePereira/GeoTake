using UnityEngine;
using UnityEngine.UI;

public class SalvarDificuldade : MonoBehaviour
{
    [SerializeField] private Button BotaoFacil;
    [SerializeField] private Button BotaoMedio;
    [SerializeField] private Button BotaoDificil;


    // Chave para PlayerPrefs
    private const string CHAVE_DIFICULDADE = "Dificuldade";

    void Start()
    {
        // Adicionar listeners aos botões existentes
        if (BotaoFacil != null)
        {
            BotaoFacil.onClick.AddListener(DificuldadeFacil);
            Debug.Log("Botão de dificuldade facil acionado");
        }
        else
        {
            Debug.LogError("ERRO: Botão dificuldade facil não foi atribuído no Inspector!");
        }

        if (BotaoMedio != null)
        {
            BotaoMedio.onClick.AddListener(DificuldadeMedio);
            Debug.Log("Botão de dificuldade media conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Botão de dificuldade media não foi atribuído no Inspector!");
        }

        if (BotaoDificil != null)
        {
            BotaoDificil.onClick.AddListener(DificuldadeDificil);
            Debug.Log("Botão de dificuldade dificil conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Botão de dificuldade dificil não foi atribuído no Inspector!");
        }

        // Carregar e mostrar a opção salva anteriormente
        AtualizarInterface();
    }

    public void DificuldadeFacil()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_DIFICULDADE, 1);

        // Log de confirmação
        Debug.Log("OPÇÃO SALVA: 1 (facil)");

        // Atualizar interface
        AtualizarInterface();
    }

    public void DificuldadeMedio()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_DIFICULDADE, 2);

        // Log de confirmação
        Debug.Log("OPÇÃO SALVA: 2 (medio)");

        // Atualizar interface
        AtualizarInterface();
    }

    public void DificuldadeDificil()
    {
        // Salvar a escolha
        PlayerPrefs.SetInt(CHAVE_DIFICULDADE, 3);

        // Log de confirmação
        Debug.Log("OPÇÃO SALVA: 3(dificil)");

        // Atualizar interface
        AtualizarInterface();
    }

    private void AtualizarInterface()
    {
        int dificuldadeSetada = PlayerPrefs.GetInt(CHAVE_DIFICULDADE, 1);

        Debug.Log("OPÇÃO CARREGADA: dificuldade configurado para: " + dificuldadeSetada);

    }

    public static int ObterDificuldade()
    {
        int dificuldade = PlayerPrefs.GetInt(CHAVE_DIFICULDADE, 1);
        Debug.Log("CONFIGURAÇÃO OBTIDA: dificuldade configurado para: " + dificuldade);
        return dificuldade;
    }
}