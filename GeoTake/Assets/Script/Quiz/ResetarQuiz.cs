using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetarQuiz : MonoBehaviour
{

    [SerializeField] private string CarregarJogo;

    public void Resetar()
    {     
        QuizMensager.acertosTotais = 0;
            SceneManager.LoadScene(CarregarJogo);
        

    }

        
    

    
}
