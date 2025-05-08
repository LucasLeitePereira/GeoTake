using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public static Icon ic;
    private Vector3 originalScale;
    private bool verificar = true;
    private float temp;
    void OnEnable()
    {
       
        originalScale = transform.localScale;
        if(verificar == true){
        StartCoroutine(ScaleRoutine());
        verificar = false;
        }
    }
     void Update()
    {
          temp = Mathf.RoundToInt(Time.time);
        if(temp %15 == 0 && verificar == false)
        {
            StartCoroutine(ScaleReduz());
          
        }
    }
    IEnumerator ScaleRoutine()
    {
       
        transform.localScale = Vector3.zero;

       
        float t = 0;
        while (t < 1f)
        {
            t += Time.deltaTime * 2f; 
            transform.localScale = Vector3.Lerp(Vector3.zero, originalScale, t);
            yield return null;
        }

    }
    IEnumerator ScaleReduz() {
       
       float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime * 2f;
            transform.localScale = Vector3.Lerp(originalScale, Vector3.zero, t);
            yield return null;
        }
            verificar = true;
            gameObject.SetActive(false);
        
    }
}



