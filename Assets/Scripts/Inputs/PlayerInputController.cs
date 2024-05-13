using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : InputController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    // 캐릭터 이동
    public void OnMove(InputValue inputValue)
    {
        CallMoveEvent(inputValue.Get<Vector2>().normalized);
    }

    // 캐릭터 시점
    public void OnLook(InputValue inputValue)
    {
        Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(inputValue.Get<Vector2>());
        Vector2 playerLookPosition = (mouseWorldPosition - (Vector2)transform.position).normalized;

        if(playerLookPosition.magnitude > .9f)
        {
            CallLookEvent(playerLookPosition);
        }
    }
}
