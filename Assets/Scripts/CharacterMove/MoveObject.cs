using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private InputController inputController;
    private Rigidbody2D rigidbody;

    private Vector2 moveDirection = Vector2.zero;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        inputController.OnMoveEvent += SetMoveDirection;
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
}
