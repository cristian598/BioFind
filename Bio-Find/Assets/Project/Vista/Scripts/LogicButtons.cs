using UnityEngine;
using UnityEngine.SceneManagement; // Para cargar escenas
using UnityEngine.UI; // Para trabajar con UI

public class LogicButtons : MonoBehaviour
{
    public Canvas menuCanvas; // El Canvas del menú
    public Canvas gameCanvas; // El Canvas del juego (si tienes uno)

    public Button startButton; // Botón para iniciar el juego
    public Button exitButton;  // Botón para salir del juego

    void Start()
    {
        // Asegúrate de que los canvases están asignados
        if (menuCanvas != null)
            menuCanvas.enabled = true; // Activa el Canvas del menú

        // Asegúrate de que los botones están asignados
        if (startButton != null)
            startButton.onClick.AddListener(OnStartButtonClicked);

        if (exitButton != null)
            exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    void OnStartButtonClicked()
    {
        

        if (menuCanvas != null)
            menuCanvas.enabled = false; // Desactiva el Canvas del menú

        // Aquí podrías cargar una escena si estás usando escenas diferentes
        // SceneManager.LoadScene("GameScene");
    }

    void OnExitButtonClicked()
    {
        // Cierra la aplicación
        Application.Quit();
    }
}
