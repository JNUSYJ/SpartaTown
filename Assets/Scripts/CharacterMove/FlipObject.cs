using UnityEngine;

public class FilpObject : MonoBehaviour
{
    private InputController inputController;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        inputController = GetComponentInParent<InputController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        inputController.OnLookEvent += Flip;
    }

    private void Flip(Vector2 direction)
    {
        spriteRenderer.flipX = Mathf.Abs(Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) > 90f;
    }
}