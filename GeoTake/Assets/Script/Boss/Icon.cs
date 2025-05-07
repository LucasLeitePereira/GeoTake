using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public static Icon ic;
    private Vector3 originalScale;
    private float temp;
    public bool validar = true;
    void Start()
    {
        // Armazena o tamanho original do objeto
        originalScale = transform.localScale;
        StartCoroutine(ScaleRoutine());
    }
     void Update()
    {
          temp += Time.deltaTime;
        if(temp > 9 && validar == true)
        {
            StartCoroutine(ScaleReduz());
          
        }
    }
    IEnumerator ScaleRoutine()
    {
        // Começa invisível
        transform.localScale = Vector3.zero;

        // Aumenta até o tamanho original
        float t = 0;
        while (t < 1f)
        {
            t += Time.deltaTime * 2f; // 0.5s total
            transform.localScale = Vector3.Lerp(Vector3.zero, originalScale, t);
            yield return null;
        }

    }
    IEnumerator ScaleReduz() {
        // Diminui até 0
       float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime * 2f;
            transform.localScale = Vector3.Lerp(originalScale, Vector3.zero, t);
            yield return null;
        }


        if (t > 1f)
        {
            validar = false;
            temp = 0;
            gameObject.SetActive(false);
        }
    }
}



