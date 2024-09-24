using UnityEngine;

public class DisablePlaneAndLightOnCanvasDisable : MonoBehaviour
{
    public GameObject canvas; // Asigna tu Canvas aquí
    public GameObject plane;  // Asigna tu plano aquí
    public Light lightToDisable; // Asigna la luz aquí

    void Update()
    {
        // Verifica si el canvas está desactivado
        if (canvas != null && !canvas.activeInHierarchy)
        {
            // Desactiva el plano
            if (plane != null)
            {
                plane.SetActive(false);
            }

            // Desactiva la luz
            if (lightToDisable != null)
            {
                lightToDisable.enabled = false;
            }
        }
        else if (canvas != null && canvas.activeInHierarchy)
        {
            // Si el canvas está activo, asegúrate de que el plano y la luz estén activos
            if (plane != null)
            {
                plane.SetActive(true);
            }
            if (lightToDisable != null)
            {
                lightToDisable.enabled = true;
            }
        }
    }
}
