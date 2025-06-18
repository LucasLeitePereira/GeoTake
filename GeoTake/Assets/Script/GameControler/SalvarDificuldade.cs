using UnityEngine;
using UnityEngine.UI;

public class SalvarDificuldade : MonoBehaviour
{
    public static SalvarDificuldade sd;

    [SerializeField] private GameObject player;
    [SerializeField] private Button BotaoFacil;
    [SerializeField] private Button BotaoMedio;
    [SerializeField] private Button BotaoDificil;
    
    public bool medio = false; 
    public bool dificil = false;
    public bool player1 = false;

    // Chave para PlayerPrefs
    private const string CHAVE_DIFICULDADE = "Dificuldade";

    private void Awake()
    {
        if(sd == null)
        {
            sd = this;
        }
    }

    void Start()
    {
        

        if (BotaoMedio != null)
        {
            BotaoMedio.onClick.AddListener(DificuldadeMedio);
            Debug.Log("Bot�o de dificuldade media conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Bot�o de dificuldade media n�o foi atribu�do no Inspector!");
        }

        if (BotaoDificil != null)
        {
            BotaoDificil.onClick.AddListener(DificuldadeDificil);
            Debug.Log("Bot�o de dificuldade dificil conectado com sucesso");
        }
        else
        {
            Debug.LogError("ERRO: Bot�o de dificuldade dificil n�o foi atribu�do no Inspector!");
        }

   
    }

    public void DificuldadeFacil()
    {

        
      
       
 
    }
    public void DificuldadeMedio()
    {

        medio = true;
        // Log de confirma��o
        Debug.Log("OP��O SALVA: 2 (medio)");
        medio = true;

      
    }

    public void DificuldadeDificil()
    {
        // Salvar a escolha
        dificil = true;

        // Log de confirma��o
        Debug.Log("OP��O SALVA: 3(dificil)");
        dificil = true;

        // Atualizar interface
        
    }

    

    public static int ObterDificuldade()
    {
        int dificuldade = PlayerPrefs.GetInt(CHAVE_DIFICULDADE, 1);
        Debug.Log("CONFIGURA��O OBTIDA: dificuldade configurado para: " + dificuldade);
        return dificuldade;
    }

    public void Player1()
    {
        
        player1 = true;

    }
}