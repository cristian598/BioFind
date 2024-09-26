using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvaPause : MonoBehaviour
{
    public GameObject CanvaPausa;

    bool Cambio;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cambio = !Cambio;
            CanvaPausa.SetActive(Cambio);
        }
    }
}
