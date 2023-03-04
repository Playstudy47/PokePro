using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Object/Card", order = 2)]




public class Card : ScriptableObject
{
    [SerializeField]
    protected string cardName;
    [SerializeField]
    protected string card_Code;
    [SerializeField]
    protected string card_Name;
    [SerializeField]
    protected CardType card_Type;
    [SerializeField]
    protected string card_Block;
    [SerializeField]
    protected string card_Note;
    [SerializeField]
    protected Theme card_Theme;


}
   public enum Mode
    {
        Idle, Playing, DeckFix
    }

    public enum CardType
    {
        Monster, Item, Supporter, Energy
    }
    
    public enum Phase
    {
        BattleReady, Idle, Battle, PokemonCheck
    }

    public enum ElementType
    {
        Fire, Leaf, Fight, Water, Iron, Dark, Electric, Psychic, Normal
    }

    public enum EnergyType
    {
        Normal, Special
    }

    public enum Theme
    {
        Fusion, SingleStrike, RapidStrike, None
    }

    public enum Evolved
    {
        Basic, Evolved_One, Evolved_Two, V, GX
    }
    public enum Status_Condition
    {
        Idle, Poison, Sleep, Burn, Paralyze
    }
    public enum Player
    {
        Player1, Player2
    }



