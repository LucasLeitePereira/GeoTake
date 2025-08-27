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

    

    private void Awake()
    {
        if(sd == null)
        {
            sd = this;
        }
    }


    public void DificuldadeMedio()
    {

        medio = true;
       
        Debug.Log("OPÇÃO SALVA: (medio)");
     

      
    }

    public void DificuldadeDificil()
    {
       

        Debug.Log("OPÇÃO SALVA: (dificil)");
        dificil = true;

       
        
    }

    public void Player1()
    {
        
        player1 = true;

    }
}