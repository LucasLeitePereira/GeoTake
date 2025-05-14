using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DificuldadeMedio : MonoBehaviour
{
    public GameController game;

    private void Start()
    {
        game = GameController.gc;

        game.timeCount = 60;

    }
}
