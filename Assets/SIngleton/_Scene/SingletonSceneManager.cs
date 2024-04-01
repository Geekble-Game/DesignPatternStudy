using System;
using UnityEngine;

public class SingletonSceneManager : MonoBehaviour
{
    private void Start()
    {
        Singleton_Test1.I.Log("SingletonManager");
        Singleton_Test2.Instance.Log("SingletonManager2");
    }
}
