using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introScript : MonoBehaviour
{
    [SerializeField]
    GameObject spirit;

    [SerializeField]
    GameObject shadeIllustration;

    [SerializeField]
    GameObject blackScreen;

    [SerializeField]
    Animator anim;

    [SerializeField]
    AudioSource trainAudio;

    // Start is called before the first frame update
    void Start()
    {
        shadeIllustration.SetActive(false);
        spirit.SetActive(false);
        StartCoroutine(FadeTimer());
    }



    public void SpiritAppear()
    {
        StartCoroutine(LightFlicker());
    }

    IEnumerator LightFlicker()
    {
        yield return new WaitForSeconds(0.2f);
        shadeIllustration.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        shadeIllustration.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        shadeIllustration.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        shadeIllustration.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        shadeIllustration.SetActive(true);
        spirit.SetActive(true);
    }

    IEnumerator FadeTimer()
    {
        yield return new WaitForSeconds(12);
        anim.Play("Fade");
        yield return new WaitForSeconds(1);
        trainAudio.Play();
        blackScreen.SetActive(false);
    }
}
