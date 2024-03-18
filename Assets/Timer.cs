using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    [SerializeField] private Text timerText;

    private float timerElapsed;
    private int minutes, seconds, cents;
    
    private void Update()
    {
        timerElapsed += Time.deltaTime;
        minutes = (int)(timerElapsed / 60f);
        seconds = (int)(timerElapsed - minutes * 60f);
        cents = (int)((timerElapsed -(int)timerElapsed) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

    }
    public void Jugar()
    {
        SceneManager.LoadScene("Jugar");
    }
    public void Salir()
    {
        Application.Quit();
    }

}
