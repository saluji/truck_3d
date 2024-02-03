using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;
    private void OnMouseUpAsButton()
    {
        bool state = animator.GetBool("isOpen");
        animator.SetBool("isOpen", !state);
    }
}
