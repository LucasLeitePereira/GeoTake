using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instancia;

    public AudioClip musicaMenu;
    public AudioClip musicaFase1;
    public AudioClip musicaBoss;
    public AudioClip musicaFase2;

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

        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += TrocarMusicaPorCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= TrocarMusicaPorCena;
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
