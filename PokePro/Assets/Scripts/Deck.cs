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

    public Deck()
    {
        deckName = "TestDeck1";
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
        TextAsset text = Resources.Load<TextAsset>("Deck/" + deckName);
        
        DeckMaterial deckMaterial = JsonUtility.FromJson<DeckMaterial>(text.text);
        this.deckList = deckMaterial.Parse();
        foreach(Card c in deckList)
        {
            Debug.Log(c.cardNote);
        }
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

