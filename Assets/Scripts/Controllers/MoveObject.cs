using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private InputController inputController;
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    private Vector2 moveDirection = Vector2.zero;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        inputController.OnMoveEvent += SetMoveDirection;
        inputController.OnLookEvent += Look;
    }

    private void FixedUpdate()
    {
        Move(moveDirection);
    }

    private void SetMoveDirection(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void Move(Vector2 direction)
    {
        direction *= 5;
        rigidbody.velocity = direction;
    }

    private void Look(Vector2 direction)
    {
        spriteRenderer.flipX = Mathf.Abs(Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) > 90f;
    }
}
