using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public string[] lines;

    public AudioSource As;
    public AudioClip[] audios;
    public float textSpeed=0.1f;

    int index, enumerado;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.E))
        {
            NextLine();

            if (enumerado < audios.Length)
            {
                As.clip = audios[enumerado];
                As.Play();
                enumerado++;
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;

        StartCoroutine(WriteLine());
    }

    public void StartDialogueSec()
    {
       index = 1;

        StartCoroutine(WriteLine());
    }
    

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;
            
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    
}
