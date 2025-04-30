using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ControladorDeVolume : MonoBehaviour
{
    [SerializeField] private Slider sliderVolume;
    [SerializeField] private AudioMixer mixerPrincipal; // Opcional, se estiver usando AudioMixer

    private const string CHAVE_VOLUME = "VolumeDoJogo";

    void Start()
    {
        // Carrega o volume salvo (ou usa 1.0 como padrão = 100%)
        float volumeSalvo = PlayerPrefs.GetFloat(CHAVE_VOLUME, 1.0f);

        // Configura o slider com o valor salvo
        sliderVolume.value = volumeSalvo;

        // Adiciona um listener para quando o valor do slider mudar
        sliderVolume.onValueChanged.AddListener(AtualizarVolume);

        // Aplica o volume inicial
        AtualizarVolume(volumeSalvo);
    }

    public void AtualizarVolume(float volume)
    {
        // Salva o novo valor de volume
        PlayerPrefs.SetFloat(CHAVE_VOLUME, volume);

        // Se estiver usando AudioMixer, converte o valor para decibéis
        // (Os mixers da Unity usam escala logarítmica)
        if (mixerPrincipal != null)
        {
            // Converte valor do slider (0 a 1) para decibéis (-80dB a 0dB)
            // Quando volume = 0, definimos como -80dB (praticamente mudo)
            float volumeEmDecibeis = volume > 0.001f ? Mathf.Log10(volume) * 20 : -80f;
            mixerPrincipal.SetFloat("Volume", volumeEmDecibeis);
        }
        else
        {
            // Se não estiver usando mixer, pode ajustar diretamente o volume do AudioListener
            AudioListener.volume = volume;
        }

        // Força o salvamento imediato (opcional, Unity normalmente salva automaticamente)
        // PlayerPrefs.Save();
    }
}