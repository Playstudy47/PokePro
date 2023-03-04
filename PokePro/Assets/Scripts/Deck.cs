using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deckList{get; set;}
    public string deckName{get; set;}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shuffle()
    {
        for (int p = 0; p < deckList.Count; p++)
            Swap(p, Random.Range(0, deckList.Count));
    }
    private void Swap(int a, int b)
    {
        Card c = deckList[b]; deckList[b] = deckList[a]; deckList[a] = c;
    }
}
