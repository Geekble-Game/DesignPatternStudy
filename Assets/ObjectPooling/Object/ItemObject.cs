using UnityEngine;

public class ItemObject : PoolableObject
{
    public override void Pop()
    {
        Debug.Log("Pop ItemObject");
    }
}
