using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void OnMouseDown()
    {
        Card c = DrawCard();
        
        var card = new GameObject(c.cardName, typeof(SpriteRenderer)).AddComponent<Card>();
        
        card = c;
        Debug.Log(card.cardCode);
        playerHands.GetComponent<Hands>().AddToHands(card);
    }

    public Card DrawCard()
    {
        Card lastCard = deckList[deckList.Count - 1];
        deckList.RemoveAt(deckList.Count - 1);
        return lastCard;
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
                list.Add(cardMaterial.Parse());
            }
            return list;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerHands = GameObject.Find("Hands");
        TextAsset text = Resources.Load<TextAsset>("Deck/" + deckName);
        
        DeckMaterial deckMaterial = JsonUtility.FromJson<DeckMaterial>(text.text);
        this.deckList = deckMaterial.Parse();
        Shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

