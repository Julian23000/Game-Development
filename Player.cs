using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject pnl_win;
    [SerializeField] private GameObject pnl_lose;

    public Image Healthbar;
    public float health;
    public float MaxHealth;

    void Start()
    {
        MaxHealth = health;
    }

    void Update()
    {
        Healthbar.fillAmount = Mathf.Clamp(health / MaxHealth, 0, 1);
    }
}
