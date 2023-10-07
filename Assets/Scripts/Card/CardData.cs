using UnityEngine;

namespace Card
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/", order = 1)]
    public class CardData : ScriptableObject
    {
        public string name;
        public string ImagePath;
        public int damage;
        public int price;
        public int hp;
    }
}