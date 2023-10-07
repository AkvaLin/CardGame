using Interfaces;

namespace Card
{
    public class Card : Entity, IAttacking, IDamageable
    {
        public void Attack(Enemy.Enemy enemy)
        {
            enemy.GetDamage(damage);
        }

        public void GetDamage(int damage)
        {
            hp -= damage;
        }
    }
}