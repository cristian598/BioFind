using UnityEngine;
using UnityEngine.SceneManagement; // Para cargar escenas
using UnityEngine.UI; // Para trabajar con UI

public class PauseController : MonoBehaviour
{
    public Canvas pauseCanvas; // El Canvas de pausa
    public Button resumeButton; // Botón para reanudar el juego
    public Button exitButton;   // Botón para salir del juego

    private bool isPaused = false;

    void Start()
    {
        // Asegúrate de que el Canvas de pausa está asignado
        if (pauseCanvas != null)
        {
            pauseCanvas.enabled = false; // El Canvas de pausa está oculto al inicio
        }

        // Asegúrate de que los botones están asignados
        if (resumeButton != null)
            resumeButton.onClick.AddListener(OnResumeButtonClicked);

        if (exitButton != null)
            exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    void Update()
    {
        // Verifica si se presiona la tecla de pausa (por ejemplo, 'P')
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // Pausa o reanuda el juego
        pauseCanvas.enabled = isPaused; // Muestra u oculta el Canvas de pausa
        Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked; // Cambia el estado del cursor
        Cursor.visible = isPaused; // Muestra u oculta el cursor
    }

    void OnResumeButtonClicked()
    {
        TogglePause(); // Cambia el estado de pausa
    }

    void OnExitButtonClicked()
    {
        // Puedes cargar la escena principal o salir del juego
        // Si estás usando una escena principal para el menú
        SceneManager.LoadScene("SampleScene"); // Asegúrate de que "MainMenuScene" sea el nombre correcto
        // Para salir del juego (solo funciona en builds)
        // Application.Quit();
    }
}
