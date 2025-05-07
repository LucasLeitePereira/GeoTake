using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quiz
{
    public string perguntaTexto;
    public string[] alternativasTexto;
    public int indexCorreto;
}
public class QuizData : ScriptableObject {   
}

