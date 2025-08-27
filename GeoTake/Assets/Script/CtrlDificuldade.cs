using UnityEngine;

public class CtrlDificuldade : MonoBehaviour
{
    public Vector3 player;

    public GameObject Player1;


    private void Awake()
    {
        player = Player1.transform.position
;    }

    void Start()
    {
        Player1.transform.position = player;
        
        if (SalvarDificuldade.sd.medio && GameController.gc != null)
        {
            GameController.gc.timeCount = 60;
        }
        else if (SalvarDificuldade.sd.dificil && GameController.gc != null)
        {
            GameController.gc.timeCount = 40;
        }

        if (SalvarDificuldade.sd.player1 && GameController.gc != null)
        {
            Player1.transform.position = new Vector3(999, 999, 999);
        }
    }
}
