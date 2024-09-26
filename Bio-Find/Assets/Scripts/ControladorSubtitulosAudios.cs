using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSubtitulosAudios : MonoBehaviour
{
    public GameObject CanvaInicial,CanvaSubtitulo, CanvaPausa;
    public AudioSource As;
    public AudioClip Inicial, Segundo, Tercero;
    public DialogueScript dialogueScript;

    void Awake()
    {
        As.clip = Inicial;
        As.Play();
        CanvaInicial.SetActive(true);
    }

    public void ApagarInicial()
    {
        CanvaInicial.SetActive(false);
    }
    public void ApagarPausa()
    {
        CanvaPausa.SetActive(false);
    }

    public void ActivarSubtitulo()
    {
        CanvaSubtitulo.SetActive(true);
    }

    public void SegundoAudio()
    {
        As.Stop();
        CanvaInicial.SetActive(false);
        As.clip=Segundo;
        As.Play();
        StartCoroutine(MostrarCanva());
    }

   IEnumerator MostrarCanva()
    {
        yield return new WaitForSeconds(12);
        dialogueScript.NextLine();
        As.clip = Tercero;
        As.Play();
    }

}
