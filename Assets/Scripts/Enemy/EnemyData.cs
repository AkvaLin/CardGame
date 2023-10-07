using UnityEngine;

namespace Enemy
{
    public class EnemyData: ScriptableObject
    {
        public string name;
        public GameObject image;
        public int damage;
        public int price;
        public int hp;
    }
}