using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LoadingScreenEventTransmitter : MonoBehaviour
{

    public event Action OnAnimationFinished;
    public event Action OnAnimationStart;

    private Animator animator;

    public int NumberOfClips { get; private set; }

    private void Awake()
    {
        animator = GetComponent<Animator>();
        NumberOfClips = animator.GetNextAnimatorClipInfoCount(0);
    }

    public void AnimationEventOnFinishedCalled()
    {
        if (Debug.isDebugBuild) Debug.Log($"<color=purple>GETCALLED</color>");
        
        OnAnimationFinished?.Invoke();
    }

    public void AnimationEventOnStartCalled()
    {
        OnAnimationStart?.Invoke();
    }
}
