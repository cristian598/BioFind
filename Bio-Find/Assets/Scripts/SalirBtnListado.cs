using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirBtnListado : MonoBehaviour
{
    public GameObject CanvaPrincipal, CanvaListado;

    public void Salir()
    {
        CanvaPrincipal.SetActive(true);
        CanvaListado.SetActive(false);
    }

    public void Salir2()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
}
