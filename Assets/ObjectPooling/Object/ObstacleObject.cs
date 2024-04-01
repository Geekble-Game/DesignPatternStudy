using UnityEngine;

public class ObstacleObject : PoolableObject
{
    public override void Pop()
    {
        Debug.Log("Pop ObstacleObject");
    }
}
