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
    public AudioClip somDano2;
    public AudioClip somDerrota;
    public AudioClip somVitoria;

    private AudioSource audioSource;     // Música de fundo
    private AudioSource audioEfeitos;    // Efeitos sonoros

    void Awake()
    {
        // Singleton
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

        // Criar fontes de som
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.playOnAwake = false;

        audioEfeitos = gameObject.AddComponent<AudioSource>();
        audioEfeitos.loop = false;
        audioEfeitos.playOnAwake = false;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += TrocarMusicaPorCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= TrocarMusicaPorCena;
    }

    // Toca o som de dano específico para o personagem
    public void TocarSomDano()
    {
        if (somDano != null)
            audioEfeitos.PlayOneShot(somDano);
    }

    public void TocarSomDano2()
    {
        if (somDano2 != null)
            audioEfeitos.PlayOneShot(somDano2);
    }

    public void TocarSomDerrota()
    {
        if (somDerrota != null)
            audioEfeitos.PlayOneShot(somDerrota);
    }

    public void TocarSomVitoria()
    {
        if (somVitoria != null)
            audioEfeitos.PlayOneShot(somVitoria);
    }

    // Trocar a música de fundo de acordo com a cena
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
            case "somDano":
                novaMusica = somDano;
                break;
        }

        // Troca a música de fundo apenas se for diferente da atual
        if (novaMusica != null && audioSource.clip != novaMusica)
        {
            audioSource.clip = novaMusica;
            audioSource.Play();
        }
    }
}
