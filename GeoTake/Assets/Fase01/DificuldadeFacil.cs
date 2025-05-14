using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DificuldadeFacil : MonoBehaviour
{
    public GameController game;

    private void Start()
    {
        game = GameController.gc;

        game.timeCount = 90;

    }
    
}
