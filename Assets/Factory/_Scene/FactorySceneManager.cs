using System;
using UnityEngine;

public enum MONSTER_TYPE
{
    ORC,
    GOBLIN
}

public class FactorySceneManager : MonoBehaviour
{
    public MONSTER_TYPE monsterType;
    
    private void Start()
    {
        FactoryMonster factoryMonster = null;

        switch (monsterType)
        {
            case MONSTER_TYPE.ORC:
                factoryMonster = new FactoryMonsterOrc();
                break;
            case MONSTER_TYPE.GOBLIN:
                factoryMonster = new FactoryMonsterGoblin();
                break;
        }

        if (factoryMonster != null)
        {
            factoryMonster.CreateMonster();
        }
    }
}

