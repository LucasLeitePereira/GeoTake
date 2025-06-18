using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fase02facil : MonoBehaviour
{
    public GameController game;
    public float tempo;

    private void Start()
    {
        game = GameController.gc;

        game.timeCount = tempo;
    }
}
