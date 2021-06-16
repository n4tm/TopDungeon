using UnityEngine;

namespace Player
{
    public class SwordAttack : MonoBehaviour
    {
        private PlayerAttack player;
        void Start()
        {
            player = gameObject.transform.parent.gameObject.GetComponent<PlayerAttack>();
        }

        public void SA()
        {
            player.StartAttack();
        }

        public void EA()
        {
            player.EndAttack();
        }

    }
}
