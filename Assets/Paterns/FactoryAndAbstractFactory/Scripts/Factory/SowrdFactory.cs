using UnityEngine;

[CreateAssetMenu(fileName = "SwordFactory", menuName = "Factory/Sword")]
public  class SowrdFactory : WeaponFactory
{
    private IWeapon _weapon;
    public override IWeapon CreateWeapon()
    {
        if (_weapon == null)
        {
            return new Sword();
        }
        return _weapon;
    }
}