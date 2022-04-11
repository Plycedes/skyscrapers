using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;

    public GameObject startmenuUI;
    public GameObject settingsMenuUI;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Back()
    {
        startmenuUI.SetActive(true);
        settingsMenuUI.SetActive(false);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
