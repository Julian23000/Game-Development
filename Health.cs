using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject pnl_lose;

    public Slider healthbar;
    public float maxHealth = 100f;
    public float currentHealth;
    public float duration = 10f;

    private float timer;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.maxValue = maxHealth;
        healthbar.value = currentHealth;
        timer = duration;
        pnl_lose.SetActive(false);
    }

    void Update()
    {
        if(currentHealth > 0)
        {
            timer -= Time.deltaTime;

            if(timer < 0 )
                timer = 0;

            currentHealth = (timer / duration) * maxHealth;
            healthbar.value = currentHealth;

            if (currentHealth <= 0)
            {
                Lost();
            }
        }
    }


    private void Lost()
    {
        if(healthbar != null)
        {
            //pnl_lose.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
