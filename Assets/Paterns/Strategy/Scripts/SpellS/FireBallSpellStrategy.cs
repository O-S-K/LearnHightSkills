using UnityEngine;

[CreateAssetMenu(fileName = "FireBallSpell", menuName = "SpellStratery/FireBallSpell")]
public class FireBallSpellStrategy : SpellStratery
{
    public GameObject fireBallPrefab;
    public float speed = 10;
    public float damage = 10;
    
    public override void CastSpell(Transform origin)
    {
        new FireBallBuilder()
            .SetFireBallPrefab(fireBallPrefab)
            .SetDamage(damage)
            .SetSpeed(speed)
            .Build(origin);
    }
    
    public override void UpGrade()
    {
        levelUpgrade++;
        speed += 1;
        damage += 1;
    }
    
    class FireBallBuilder 
    {
        private GameObject fireBallPrefab;
        private float speed;
        private float damage;

        public FireBallBuilder SetFireBallPrefab(GameObject fireBallPrefab)
        {
            this.fireBallPrefab = fireBallPrefab;
            return this;
        }
        
        public FireBallBuilder SetSpeed(float speed)
        {
            this.speed = speed;
            return this;
        }
        
        public FireBallBuilder SetDamage(float damage)
        {
            this.damage = damage;
            return this;
        }

        public GameObject Build(Transform origin)
        {
            GameObject fireBall = Instantiate(fireBallPrefab, origin.position, origin.rotation);
            Rigidbody rb = fireBall.GetComponent<Rigidbody>();
            rb.velocity = origin.forward * speed;
            Destroy(fireBall, 5);
            return fireBall;
        }
    }
}