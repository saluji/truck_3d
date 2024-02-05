using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator[] animators;
    public void RestAllAnimations()
    {
        for (int i = 0; i < animators.Length; i++)
        {
            animators[i].SetBool("isOpen", false);
        }
    }
}
