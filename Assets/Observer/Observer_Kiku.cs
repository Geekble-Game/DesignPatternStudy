using UnityEngine;

public class Observer_Kiku : MonoBehaviour
{
    private void OnEnable() => ObserverSceneManager.ObserverSceneEvent += SceneEvent;
    private void OnDisable() => ObserverSceneManager.ObserverSceneEvent -= SceneEvent;

    private void SceneEvent(OBSERVER_SCENE_STATE _playStatus)
    {
        switch (_playStatus)
        {
            case OBSERVER_SCENE_STATE.START:
                Debug.Log("키쿠는 날라간다..");
                break;
            case OBSERVER_SCENE_STATE.PAUSE:
                Debug.Log("키쿠는 공중에 떠있다..");
                break;
            case OBSERVER_SCENE_STATE.RESUME:
                Debug.Log("키쿠는 우주로 갈거임");
                break;
        }
    }
}
