using UnityEngine;

public abstract class PoolableObject : MonoBehaviour 
{
    protected ObjectPool Pool;

    public virtual void Create (ObjectPool pool)
    {
        Pool = pool;

        gameObject.SetActive(false); 
    }
    
    public abstract void Pop();

    public virtual void Push ()
    {
        Pool.PushObject(this);
    }
}