using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player.PlayerAttack player;
        private BoxCollider2D BoxCol;
        private void Start()
        {
            BoxCol = GetComponent<BoxCollider2D>();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.CompareTag("MeleeWeapon") && player.isAttacking)
            {
                Destroy(gameObject);
            }
        }
    }
}
