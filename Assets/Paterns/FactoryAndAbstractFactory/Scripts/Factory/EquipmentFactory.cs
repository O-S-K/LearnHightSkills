using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "EquipmentFactory", menuName = "Factory")]
public class EquipmentFactory : ScriptableObject
{
    [SerializeField] private WeaponFactory _weaponFactory;
    [SerializeField] private GenericShieldFactory shieldFactory;

    public IWeapon CreateWeapon()
    {
        if (_weaponFactory != null)
        {
            return _weaponFactory.CreateWeapon();
        }
        return IWeapon.CreateDefault();
    }
    
    public IShield CreateShield()
    {
        if (shieldFactory != null)
        {
            return shieldFactory.CreateShield();
        }

        return IShield.CreateDefault();
    }
}