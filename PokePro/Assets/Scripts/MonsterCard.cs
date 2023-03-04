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

    public MonsterCard(string card_Code) : base(card_Code)
    {
        string filePath = "JSon/";

        TextAsset cardInfo = Resources.Load<TextAsset>(filePath + cardCode);

        this.baseMonster = cardInfo.baseMonster;
        this.evolved = ReturnEvolve(cardInfo.evolved);
        this.hp = Int32.Parse(cardInfo.hp);
        this.type = ReturnElement(cardInfo[5]);
        this.effects = MakeEffectList(card_Code);
        this.weakness = ReturnElement(cardInfo[7]);
        this.resistance = ReturnElement(cardInfo[8]);
        this.retreatCost = Int32.Parse(cardInfo[9]);
    }
}
