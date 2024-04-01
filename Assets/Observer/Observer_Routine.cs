using UnityEngine;

public class Observer_Routine : MonoBehaviour
{
    private void OnEnable() => ObserverSceneManager.ObserverSceneEvent += SceneEvent;
    private void OnDisable() => ObserverSceneManager.ObserverSceneEvent -= SceneEvent;

    private void SceneEvent(OBSERVER_SCENE_STATE _playStatus)
    {
        switch (_playStatus)
        {
            case OBSERVER_SCENE_STATE.START:
                Debug.Log("루틴은 걸어가기 시작");
                break;
            case OBSERVER_SCENE_STATE.PAUSE:
                Debug.Log("루틴은 축구를 본다..");
                break;
            case OBSERVER_SCENE_STATE.RESUME:
                Debug.Log("루틴은 다시 걸어간다..");
                break;
        }
    }
}
