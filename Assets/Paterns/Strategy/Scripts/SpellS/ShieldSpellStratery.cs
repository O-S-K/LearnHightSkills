using UnityEngine;

[CreateAssetMenu(fileName = "ShieldSpell", menuName = "SpellStratery/ShieldSpell")]
public class ShieldSpellStratery : SpellStratery
{
    public GameObject shieldPrefab;
    public float duration = 10;
    
    public override void CastSpell(Transform origin)
    {
        new ShieldBuilder()
            .SetShieldPrefab(shieldPrefab)
            .SetDuration(duration)
            .Build(origin);
    }

    public override void UpGrade()
    {
        levelUpgrade++;
        duration -= 0.1f;
    }

    class ShieldBuilder 
    {
        private GameObject shieldPrefab;
        private float duration;

        public ShieldBuilder SetShieldPrefab(GameObject shieldPrefab)
        {
            this.shieldPrefab = shieldPrefab;
            return this;
        }
        
        public ShieldBuilder SetDuration(float duration)
        {
            this.duration = duration;
            return this;
        }

        public GameObject Build(Transform origin)
        {
            GameObject shield = Instantiate(shieldPrefab, origin.position, origin.rotation);
            shield.transform.parent = origin;
            Destroy(shield, duration);
            return shield;
        }
    }
}
