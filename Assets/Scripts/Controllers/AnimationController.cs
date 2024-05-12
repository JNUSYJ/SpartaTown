using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected InputController inputController;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        inputController = GetComponentInParent<InputController>();
    }
}
