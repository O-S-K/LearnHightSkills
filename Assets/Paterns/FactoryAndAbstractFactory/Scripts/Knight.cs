using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] 
    EquipmentFactory equipmentFactory;
    private void Start()
    {
        Attack();
        Shield();
    }

    public void Attack()
    {
        equipmentFactory.CreateWeapon().Attack();
    }

    public void Shield()
    {
        equipmentFactory.CreateShield().Defend();
    }
}