using UnityEngine;

[CreateAssetMenu(fileName = "BowFactory", menuName = "Factory/Bow")]
public  class BowFactory : WeaponFactory
{
    private IWeapon _weapon;
    public override IWeapon CreateWeapon()
    {
        if (_weapon == null)
        {
            return new Bow();
        }
        return _weapon;
    }
}