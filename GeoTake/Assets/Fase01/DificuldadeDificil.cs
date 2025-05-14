using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificuldadeDificil : MonoBehaviour
{
    public GameController game;

    private void Start()
    {
        game = GameController.gc;

        game.timeCount = 40;
    }
}
