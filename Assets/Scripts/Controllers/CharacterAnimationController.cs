using Unity.VisualScripting;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private readonly float magnitudeThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
        
    }

    private void Start()
    {
        inputController.OnMoveEvent += MoveAnimation;
    }

    private void MoveAnimation(Vector2 direction)
    {
        animator.SetBool(IsWalking, direction.magnitude > magnitudeThreshold);
    }
}
