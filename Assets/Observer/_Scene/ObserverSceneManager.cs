using System;
using UnityEngine;
public enum OBSERVER_SCENE_STATE
{
    START,
    PAUSE,
    RESUME,
    LENGTH
}

public class ObserverSceneManager : MonoBehaviour
{
    public delegate void SceneChainFunc(OBSERVER_SCENE_STATE observerSceneState);
    public static event SceneChainFunc ObserverSceneEvent;
    
    public void SceneEventOn(OBSERVER_SCENE_STATE observerSceneState)
    {
        if (ObserverSceneEvent == null) return;
        
        ObserverSceneEvent(observerSceneState);
    }
    
    public void StartGame()
    {
        Debug.Log("Start Game!");
        SceneEventOn(OBSERVER_SCENE_STATE.START);
    }

    public void PauseGame()
    {
        Debug.Log("Pause Game!");
        SceneEventOn(OBSERVER_SCENE_STATE.PAUSE);
    }

    public void ResumeGame()
    {
        Debug.Log("Resume Game!");
        SceneEventOn(OBSERVER_SCENE_STATE.RESUME);
    }
}

