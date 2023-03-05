using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterCard: Card
{
    public int hp{get; set;}
    public string baseMonster{get; set;}
    public Evolved evolved{get; set;}
    public ElementType type{get; set;}
    public ElementType weakness{get; set;}
    public ElementType resistance{get; set;}
    public int retreatCost{get; set;}
    public Rule rule{get; set;}
}
