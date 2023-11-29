using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAnimation : MonoBehaviour
{
    public Animator animator;
    private void OnMouseUpAsButton()
    {
        bool currentState = animator.GetBool("isOpen");
        animator.SetBool("isOpen", !currentState);
    }
}
