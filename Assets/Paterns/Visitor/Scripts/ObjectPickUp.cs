using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    public PowerUpData powerUpData;
    
    private void OnTriggerEnter(Collider other)
    {
        var healthComponent = other.GetComponent<HealthComponent>();
        if (healthComponent != null)
        {
            healthComponent.Accept(powerUpData);
            Destroy(gameObject);
        }
        
        var manaComponent = other.GetComponent<ManaComponent>();
        if (manaComponent != null)
        {
            manaComponent.Accept(powerUpData);
            Destroy(gameObject);
        }
    }
}