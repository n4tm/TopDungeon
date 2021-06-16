using Enemy;
using UnityEngine;

namespace Player
{
    public class SwordAttack : MonoBehaviour
    {
        [SerializeField] private int tempDamageAmount;
        public EnemyLife targetLife;
        private PlayerAttack player;

        void Start()
        {
            player = GetComponentInParent<PlayerAttack>();
        }

        public void SA()
        {
            player.StartAttack();
        }

        public void EA()
        {
            player.EndAttack();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy") && player.isAttacking)
            {
                targetLife = other.gameObject.GetComponent<Enemy.Enemy>().life;
                targetLife.TakeDamage(tempDamageAmount);
                if (targetLife.isDead) Destroy(other.gameObject);
            }
        }

    }
}
