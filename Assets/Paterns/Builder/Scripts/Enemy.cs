using UnityEngine;


public class Enemy : MonoBehaviour
{
    public enum TypeWeapons
    {
        Gun,
        Melee
    }

    public string Name { get; set; }
    public int Health { get; set; }

    public float Speed { get; set; }
    public int Damage { get; set; }

    public bool IsBoss { get; set; }
}


// data
[System.Serializable]
public class EnemyData
{
    public Enemy.TypeWeapons Weapon;

    public EnemyData Build(Enemy.TypeWeapons weapons)
    {
        Weapon = weapons;
        return this;
    }
}


public class EnemyDirector
{
    
    public Enemy Constuct(EnemyBuilder enemyBuilder)
    {
        enemyBuilder.AddHealthComponent();
        return enemyBuilder.Build();
    }
    
    public Enemy Constuct(EnemyBuilder enemyBuilder, EnemyData enemyData)
    {
        enemyBuilder.AddHealthComponent();
        enemyBuilder.AddWeaponComponent(enemyData);
        return enemyBuilder.Build();
    }
}

public interface IEnemyBuilder
{
   
}

public interface IFinalEnemyBuilder
{
    
}

public class EnemyBuilder
{
    private EnemyData enemyData;
    private Enemy enemy;
    private Enemy.TypeWeapons weapon;


    // public string name;
    // public int health;
    // public float speed;
    // public int damage;
    // public bool isBoss;

    // public EnemyBuilder WithName(string name)
    // {
    //     this.name = name;
    //     return this;
    // }
    //
    // public EnemyBuilder WithHealth(int health)
    // {
    //     this.health = health;
    //     return this;
    // }
    //
    // public EnemyBuilder WithSpeed(float speed)
    // {
    //     this.speed = speed;
    //     return this;
    // }
    //
    // public EnemyBuilder WithDamage(int damage)
    // {
    //     this.damage = damage;
    //     return this;
    // }
    //
    // public EnemyBuilder WithIsBoss(bool _isBoss)
    // {
    //     this.isBoss = _isBoss;
    //     return this;
    // }

    public void AddHealthComponent()
    {
        // enemy.AddComponent<HeatlComponent>();
    }

    public void AddWeaponComponent(EnemyData data)
    {
        enemyData = data;
        weapon = data.Weapon;
        // enemy.AddComponent<WeaponComponent>();
    }

    public Enemy Build()
    {
        var enemybuild = enemy;
        enemybuild = new GameObject().AddComponent<Enemy>();
        return enemybuild;
    }
}