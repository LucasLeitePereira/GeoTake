using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instancia;

    public AudioClip musicaMenu;
    public AudioClip musicaFase1;
    public AudioClip musicaBoss;
    public AudioClip musicaFase2;
    public AudioClip somDano;
    public AudioClip somDerrota;
    public AudioClip somVitoria;

//tem que criar o codifo la em baixo e criar o if para personagem masc e fem 


    private AudioSource audioSource;

    void Awake()
    {
        // Garante que só exista 1 MusicManager na cena
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Primeiro AudioSource toca música
        audioSource = GetComponent<AudioSource>();

        // Cria novo AudioSource só para efeitos
        audioEfeitos = gameObject.AddComponent<AudioSource>();

        audioSource = GetComponent<AudioSource>();
    }

    private AudioSource audioEfeitos;

    void OnEnable()
    {
        SceneManager.sceneLoaded += TrocarMusicaPorCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= TrocarMusicaPorCena;
    }

    public void TocarSomDano()
    {
        if (somDano != null)
            audioEfeitos.PlayOneShot(somDano);
    }

    public void TocarSomDerrota()
    {
        if (somDerrota != null)
            audioEfeitos.PlayOneShot(somDerrota);
    }


    void TrocarMusicaPorCena(Scene cena, LoadSceneMode modo)
    {
        AudioClip novaMusica = null;

        switch (cena.name)
        {
            case "Tela de Menu":
                novaMusica = musicaMenu;
                break;
            case "Fase01":
                novaMusica = musicaFase1;
                break;
            case "Boss":
                novaMusica = musicaBoss;
                break;
            case "Fase02":
                novaMusica = musicaFase2;
                break;
  
        }

        if (novaMusica != null && audioSource.clip != novaMusica)
        {
            audioSource.clip = novaMusica;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
