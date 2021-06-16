using UnityEngine;

namespace LifeSystem
{
    public abstract class LifeBehaviour : MonoBehaviour, ILife
    {
        protected int life;
        public bool isDead;
        
        public void TakeDamage(int damageAmount)
        {
            if (damageAmount < life && life > 0)
            {
                life -= damageAmount;
                Debug.Log(life);
            }
            else
            {
                Death();
            }
        }

        public void Death()
        {
            Debug.Log(gameObject.name + " is dead.");
            isDead = true;
        }
    }
}