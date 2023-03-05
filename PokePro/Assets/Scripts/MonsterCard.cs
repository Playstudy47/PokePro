using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterCard: Card
{
    [SerializeField]
    public int hp{get; set;}
    [SerializeField]
    public string baseMonster{get; set;}
    [SerializeField]
    public Evolved evolved{get; set;}
    [SerializeField]
    public ElementType type{get; set;}
    [SerializeField]
    public ElementType weakness{get; set;}
    [SerializeField]
    public ElementType resistance{get; set;}
    [SerializeField]
    public int retreatCost{get; set;}
    [SerializeField]
    public Rule rule{get; set;}
}
