using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/UnitStats")]
public class UnitStats : ScriptableObject {

    public float attackDamage;
    public float attackRange;
    public float attackSpeed;
    public float health;
}
