using LifeSystem;

namespace Enemy
{
    public class EnemyLife : LifeBehaviour
    {
        public int lifeAmount;
        private void Start()
        {
            life = lifeAmount;
        }
    }
}
