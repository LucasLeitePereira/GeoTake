using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlDificuldade : MonoBehaviour
{
    void Start()
    {
        if (SalvarDificuldade.sd.medio == true && GameController.gc != null)
        {
            GameController.gc.timeCount = 60;
        }

        if (SalvarDificuldade.sd.dificil == true && GameController.gc != null)
        {
            GameController.gc.timeCount = 40;
        }
    }
}