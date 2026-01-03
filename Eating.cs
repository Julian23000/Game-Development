using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int points = 0;
    public Text txt_points;
    public GameObject pnl_win;

    public float timer = 60f;        
    public float timeGain = 5f;      
    public Slider timerSlider;       

    private bool isTimerRunning = true;

    void Start()
    {
        if (timerSlider != null)
        {
            timerSlider.maxValue = timer;
            timerSlider.value = timer;
        }
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isTimerRunning = false;
                GameOver();
            }

            if (timerSlider != null)
                timerSlider.value = timer;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "eaten")
        {
            Destroy(collision.gameObject);

            points += 10;
            txt_points.text = points.ToString();

            timer += timeGain;
            if (timerSlider != null)
                timerSlider.value = timer;

            if (points >= 20)
            {
                pnl_win.SetActive(true);
                Time.timeScale = 0;
                isTimerRunning = false;
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
    }
}   

