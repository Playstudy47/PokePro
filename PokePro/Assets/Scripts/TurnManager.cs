using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public Phase currentPhase{get; set;}
    public int currentTurn{get; set;}

    public bool isVStarUsed;
    public bool isEnergyUsed;
    
    // Start is called before the first frame update
    void Start()
    {
        currentPhase = Phase.BattleReady;
        currentTurn = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
