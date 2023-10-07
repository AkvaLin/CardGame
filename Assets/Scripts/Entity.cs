using Card;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] private int hp; 
    [SerializeField] private int damage;
    [SerializeField] private GameObject prefab;
    [SerializeField] private string name;

}