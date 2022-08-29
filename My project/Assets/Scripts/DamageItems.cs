using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItems : MonoBehaviour
{
    [SerializeField][Range(1, 10)]  int damage = 5;
    public int Damage {get {return damage;}}
}
