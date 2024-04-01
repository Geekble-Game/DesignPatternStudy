using UnityEngine;

public class Singleton_Test1 : MonoBehaviour
{
    public static Singleton_Test1 I { get; private set; }

    private void Awake()
    {
        if (I)
        {
            DestroyImmediate(gameObject);
            return;
        }

        I = this;
    }
    
    public void Log(string _log)
    {
        Debug.Log(_log);
    }
}
