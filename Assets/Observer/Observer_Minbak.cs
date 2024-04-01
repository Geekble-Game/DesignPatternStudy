using UnityEngine;

public class Observer_Minbak : MonoBehaviour
{
    private void OnEnable() => ObserverSceneManager.ObserverSceneEvent += SceneEvent;
    private void OnDisable() => ObserverSceneManager.ObserverSceneEvent -= SceneEvent;

    private void SceneEvent(OBSERVER_SCENE_STATE _playStatus)
    {
        switch (_playStatus)
        {
            case OBSERVER_SCENE_STATE.START:
                Debug.Log("민바크는 뛴다..");
                break;
            case OBSERVER_SCENE_STATE.PAUSE:
                Debug.Log("민바크는 누울거임...");
                break;
            case OBSERVER_SCENE_STATE.RESUME:
                Debug.Log("민바크는 게임이 다시 시작해도 안움직일거임..");
                break;
        }
    }
}
