using UnityEngine;
using UnityEngine.Events;

public class HealthBarListener : MonoBehaviour
{
    // 同一个事件SO资产，和发布方拖同一个
    public IntEventSO eventSO;
    // 事件触发后要执行的响应，支持编辑器绑定方法
    public UnityEvent<int> response;

    private void OnEnable()
    {
        // 订阅SO里的事件
        eventSO.OnEventRaised += OnEventTriggered;
    }

    private void OnDisable()
    {
        // 注销事件，必须写
        eventSO.OnEventRaised -= OnEventTriggered;
    }

    // 收到事件后，执行绑定的所有响应
    private void OnEventTriggered(int value)
    {
        response.Invoke(value);
    }
}
