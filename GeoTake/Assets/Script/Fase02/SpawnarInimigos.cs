using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float contador;
    public GameObject inimigo1;
    public GameObject inimigo2;
    public GameObject inimigo3;
    public GameObject inimigo4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador > 4)
        {
            inimigo1.SetActive(true);
        }
        if (contador > 9)
        {
          inimigo3.SetActive(true);
        }
        if (contador > 14)
        {
            inimigo2.SetActive(true);
        }
        if (contador >19)
        {
            inimigo4.SetActive(true);
            this.enabled = false;
        }
    }
}
