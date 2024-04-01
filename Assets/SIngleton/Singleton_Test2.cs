using System;
using UnityEngine;

public class Singleton_Test2 : SingletonWithMono<Singleton_Test2>
{
    public void Log(string _log)
    {
        Debug.Log(_log);
    }
}
