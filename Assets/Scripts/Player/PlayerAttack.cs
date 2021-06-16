using System.Collections;
using UnityEngine;

namespace Player
{
    
    public class PlayerAttack : MonoBehaviour
    {
        public bool isAttacking;
        private bool canAttack;
        
        private Animator swordAnimator;
        private static readonly int Attack_trigger = Animator.StringToHash("Attack");

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
            canAttack = true;
            swordAnimator = gameObject.transform.GetChild(0).GetComponent<Animator>();
        }

        private void Attack()
        {
            if (canAttack) swordAnimator.SetTrigger(Attack_trigger);
            StartCoroutine(AttackDelay(2.0f));
        }
        
        
        private void Update()
        {
        
            if (Input.GetButtonDown("Fire1"))
            {
                swordAnimator.SetTrigger(Attack_trigger);
            }
        }

        private IEnumerator AttackDelay(float timeWaiting)
        {
            canAttack = false;
            yield return new WaitForSeconds(timeWaiting);
            canAttack = true;
        }
        
    }
}
