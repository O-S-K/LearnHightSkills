using System;
using UnityEngine;

public class GameManagerBuilder : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;

    private void Start()
    {
        Enemy _enemy = new EnemyDirector().Constuct(new EnemyBuilder(), enemyData);
        Debug.Log((_enemy));
    }
}