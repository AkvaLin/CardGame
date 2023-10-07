using Interfaces;

namespace Enemy
{
    public abstract class Enemy : Entity, IAttacking, IDamageable

    {
        public void GetDamage(int damage)
        {
            throw new System.NotImplementedException();
        }

        public void Attack(Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}