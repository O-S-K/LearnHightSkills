using UnityEngine;

[CreateAssetMenu(menuName = "Factory", fileName = "ShieldFactory", order = 0)]
public class GenericShieldFactory : ShieldFactory
{
    private IShield _shield;

    public override IShield CreateShield()
    {
        if (_shield == null)
        {
            return new Shield();
        }

        return _shield;
    }
}