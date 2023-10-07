using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    public class Player : MonoBehaviour, IPush
    {
        [SerializeField] private List<Card.Card> cardsOnHand = new List<Card.Card>();

        public List<Card.Card> GetCardOnHand => cardsOnHand;

        public Card.Card PushCard(int index) => cardsOnHand[index];
    }
}