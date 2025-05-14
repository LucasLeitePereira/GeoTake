using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtivarQuiz : MonoBehaviour
{
    [SerializeField] private GameObject objetoQuiz;

    public void AtivaQuiz()
    {
        objetoQuiz.SetActive(true);
    }
}

