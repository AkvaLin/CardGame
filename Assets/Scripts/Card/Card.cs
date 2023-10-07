using System;
using Interfaces;
using UnityEngine;

namespace Card
{
    public class Card : Entity, IAttacking, IDamageable
    {
        private int _price;
        [SerializeField] private CardData cardData;

        private void Start()
        {
            hp = cardData.hp;
            damage = cardData.damage;
            prefab = cardData.image;
            name = cardData.name;
            _price = cardData.price;
        }

        public void Attack(Enemy.Enemy enemy)
        {
            enemy.GetDamage(damage);
        }

        public void GetDamage(int damage)
        {
            hp -= damage;
        }

        public void Moving(Transform transform)
        {
            this.transform.position = transform.position;
        }
    }
}