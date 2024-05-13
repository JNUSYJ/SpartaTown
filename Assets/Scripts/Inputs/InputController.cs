using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;   // 키보드 입력 시 이동
    public event Action<Vector2> OnLookEvent;   // 마우스 위치로 캐릭터 시점

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
