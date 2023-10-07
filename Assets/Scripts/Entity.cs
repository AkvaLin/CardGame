using Card;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] protected int hp; 
    [SerializeField] protected int damage;
    [SerializeField] protected GameObject prefab;
    [SerializeField] protected string name;

}