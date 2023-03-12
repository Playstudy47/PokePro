using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[Serializable]
public class Deck : MonoBehaviour
{
    [SerializeField]
    List<Card> deckList;
    [SerializeField]
    string deckName;
    GameObject playerHands;
    

    public Deck()
    {
        deckName = "TestDeck1";
    }
    

    // Start is called before the first frame update
    void Start()
    {
        TextAsset text = Resources.Load<TextAsset>("Deck/" + deckName);
        
        DeckMaterial deckMaterial = JsonUtility.FromJson<DeckMaterial>(text.text);
        this.deckList = deckMaterial.Parse();
        Shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Card> ReturnDeckList()
    {
        return deckList;
    }
    public void Shuffle()
    {
        for (int p = 0; p < deckList.Count; p++)
            Swap(p, UnityEngine.Random.Range(0, deckList.Count));
    }
    private void Swap(int a, int b)
    {
        Card c = deckList[b]; deckList[b] = deckList[a]; deckList[a] = c;
    }
    public void AddCard(Card c)
    {
        deckList.Add(c);
    }

    public Card DrawCard()
    {
        Card lastCard = deckList[deckList.Count - 1];
        deckList.RemoveAt(deckList.Count - 1);
        return lastCard;
    }

    void OnMouseDown()
    {
        GameManager.Instance.DrawCards(1);
    }

    public int ReturnCount()
    {
        return deckList.Count;
    }
    
    [System.Serializable]
    public class DeckMaterial
    {
        public string[] cardCodeList;

        public List<Card> Parse()
        {
            List<Card> list = new List<Card>();
            
            foreach(string cardCode in cardCodeList)
            {
                
                TextAsset text = Resources.Load<TextAsset>("CardText/" + cardCode);
                CardMaterial cardMaterial = JsonUtility.FromJson<CardMaterial>(text.text);
                CardData cardData = cardMaterial.Parse();

                var newCard = new GameObject(cardData.cardName, typeof(SpriteRenderer)).AddComponent<Card>();
                newCard.frontImage = Resources.Load<Sprite>("CardDataBase/" + cardCode);
                newCard.backImage = Resources.Load<Sprite>("Card/CardBack");
                newCard.cardData = cardData;
                newCard.currentLocation = Location.Deck;

                

                for(int p = 0; p < newCard.cardData.effectCount; p++)
                {
                    TextAsset effectText = Resources.Load<TextAsset>("CardEffect/" + cardCode +"_"+(p + 1));
                    EffectMaterial effectMaterial = JsonUtility.FromJson<EffectMaterial>(effectText.text);
                    var newEffect = new GameObject(cardData.cardName).AddComponent<CardEffect>();
                    newEffect.effectData = effectMaterial.Parse();
                    newCard.cardEffects.Add(newEffect);
                }
                list.Add(newCard);
            }
            return list;
        }
    }



}

