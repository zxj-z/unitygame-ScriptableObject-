using UnityEngine;
using UnityEngine.Events; // 必须引用

public class PlayerHealth : MonoBehaviour
{
    // 无参数UnityEvent
    public UnityEvent OnPlayerHurt;
    // 带参数泛型UnityEvent，支持传数据
    public UnityEvent<int> OnHealthChanged;

    public int currentHealth = 100;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // 触发事件
        OnPlayerHurt.Invoke();
        OnHealthChanged.Invoke(currentHealth);
    }
}
