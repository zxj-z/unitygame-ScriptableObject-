using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private void OnEnable()
    {
        playerHealth.OnHealthChanged.AddListener(UpdateHealthUI);
    }

    private void OnDisable()
    {
        playerHealth.OnHealthChanged.RemoveListener(UpdateHealthUI);
    }

    private void UpdateHealthUI(int hp)
    {
        Debug.Log($"更新血条：{hp}");
    }
}
