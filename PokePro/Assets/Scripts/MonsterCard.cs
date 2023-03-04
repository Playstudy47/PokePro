using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MonsterCard", menuName = "Scriptable Object/MonsterCard", order = 3)]
public class MonsterCard: Card
{

    [SerializeField]
    private int hp;
    [SerializeField]
    private string baseMonster;
    [SerializeField]
    private Evolved evolved;
    [SerializeField]
    private ElementType type;
    [SerializeField]
    private ElementType weakness;
    [SerializeField]
    private ElementType resistance;
    [SerializeField]
    private int retreatCost;
}
