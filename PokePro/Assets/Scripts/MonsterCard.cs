using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterCard: Card
{
    
    public int hp;
    public string baseMonster;
    public Evolved evolved;
    public ElementType type;
    public ElementType weakness;
    public ElementType resistance;
    public int retreatCost;
    public Rule rule;
}
