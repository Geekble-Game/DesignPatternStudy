using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private PoolableObject poolObj;
    [SerializeField] private int initAllocateCount;
    [SerializeField] private int addAllocateCount;
    private Stack<PoolableObject> stack = new Stack<PoolableObject>();

    void Start() {
        Allocate (initAllocateCount);
    }

    public void Allocate (int _allocateCount) {
        for (int i = 0; i < _allocateCount; i++) {
            PoolableObject tObj = Instantiate (poolObj, transform, true);
            tObj.Create (this);
            stack.Push(tObj);
        }
    }

    public GameObject PopObject ()
    {
        if(stack.Count == 0) Allocate(addAllocateCount);
        PoolableObject obj = stack.Pop();
        obj.gameObject.SetActive(true);
        obj.Pop();
        return obj.gameObject;
    }

    public void PushObject (PoolableObject obj) {
        obj.gameObject.SetActive(false);
        stack.Push(obj);
    }
}