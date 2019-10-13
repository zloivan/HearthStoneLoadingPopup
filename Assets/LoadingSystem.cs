using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSystem : MonoBehaviour
{
    [SerializeField] private LoadingScreenEventTransmitter loadingScreenEventTransmitter;

    private bool thereAreAnimationsInsideLoadingScreen;
    private void Awake()
    {
        if (loadingScreenEventTransmitter == null)
        {
            loadingScreenEventTransmitter = GetComponentInChildren<LoadingScreenEventTransmitter>();
            
            thereAreAnimationsInsideLoadingScreen = loadingScreenEventTransmitter != null;
            
        }
        else
        {
            thereAreAnimationsInsideLoadingScreen = true;
        }

        if (thereAreAnimationsInsideLoadingScreen)
        {
            //mytodo probably delete this later
            if (Debug.isDebugBuild) Debug.Log($"<color=purple>{loadingScreenEventTransmitter.NumberOfClips}</color>");
            loadingScreenEventTransmitter.OnAnimationFinished += InsideAnimationFinishedHandler;
            loadingScreenEventTransmitter.OnAnimationStart += InsideAnimationStartedHandler;
        }
    }

    private void InsideAnimationStartedHandler()
    {
        //mytodo probably delete this later
        if (Debug.isDebugBuild) Debug.Log($"<color=purple>LoadingSystem know that Animations Inside started</color>");
    }

    private void InsideAnimationFinishedHandler()
    {
        //mytodo probably delete this later
        if (Debug.isDebugBuild) Debug.Log($"<color=purple>LoadingSystem know that Animations Inside finished</color>");
    }
}
