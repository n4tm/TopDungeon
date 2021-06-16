
using LifeSystem;
using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player.PlayerAttack player;
        private BoxCollider2D BoxCol;
        public bool gotHit;
        public EnemyLife life;
        private void Start()
        {
            life = GetComponent<EnemyLife>();
            BoxCol = GetComponent<BoxCollider2D>();
        }
    }
}
