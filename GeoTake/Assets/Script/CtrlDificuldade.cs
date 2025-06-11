using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlDificuldade : MonoBehaviour
{

    [SerializeField]
    private GameObject Player1;
    void Update()
    {
        if (SalvarDificuldade.sd.medio == true && GameController.gc != null)
        {
            GameController.gc.timeCount = 60;
        }

        else if (SalvarDificuldade.sd.dificil == true && GameController.gc != null)
        {
            GameController.gc.timeCount = 40;
        }
        
        if(SalvarDificuldade.sd.player1 == true && GameController.gc != null)
        {
            Player1.SetActive(false);
        }

       
    }
}