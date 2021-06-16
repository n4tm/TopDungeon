using System.Collections;

using UnityEngine;

namespace Player
{
    
    public class PlayerAttack : MonoBehaviour
    {        
        
        public bool isAttacking;
        private bool canAttack;
        private Animator swordAnimator;
        private PlayerLife playerlife;
        private static readonly int AttackTrigger = Animator.StringToHash("Attack");
        

        #region Animacao
        public void StartAttack()
        {
            isAttacking = true;
        }

        public void EndAttack()
        {
            isAttacking = false;
        }

        private void Start()
        {
            playerlife = GetComponentInParent<PlayerLife>();
            canAttack = true;
            swordAnimator = GetComponentInChildren<Animator>();
        }

        private void Attack()
        {
            if (canAttack)
            {
                swordAnimator.SetTrigger(AttackTrigger);
                StartCoroutine(AttackDelay(0.2f));
            }

        }
      
        
        private void Update()
        {
        
            if (Input.GetButtonDown("Fire1"))
            {
                Attack();
            }
        }

        private IEnumerator AttackDelay(float timeWaiting)
        {
            canAttack = false;
            yield return new WaitForSeconds(timeWaiting);
            canAttack = true;
        }
        #endregion
    }
}
