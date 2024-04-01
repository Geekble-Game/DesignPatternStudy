using System;
using UnityEngine;

public class ObjectPoolManager : SingletonWithMono<ObjectPoolManager>
{
    public ObjectPool itemPool;
    public ObjectPool obstaclePool;

    public void RespawnItem()
    {
        GameObject itemObj = itemPool.PopObject();
        itemObj.transform.position = new Vector3(UnityEngine.Random.Range(-3, 3), UnityEngine.Random.Range(-5, 5), 0);
    }
    
    public void RespawnObstacle()
    {
        GameObject obstacleObj = obstaclePool.PopObject();
        obstacleObj.transform.position = new Vector3(UnityEngine.Random.Range(-3, 3), UnityEngine.Random.Range(-5, 5), 0);
    }
}

