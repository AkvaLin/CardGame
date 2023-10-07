using Interfaces;

namespace Card
{
    public class Card : Entity, IAttacking
    {
        public void Attack(Enemy.Enemy enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}