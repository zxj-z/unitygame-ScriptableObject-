using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Int Event", menuName = "Events/Int 事件")]
public class IntEventSO : ScriptableObject
{
    // 定义事件
    public event Action<int> OnEventRaised;

    // 触发事件的方法：发布方调用这个方法来发事件
    public void Raise(int value)
    {
        OnEventRaised?.Invoke(value);
    }
}
