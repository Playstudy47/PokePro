using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bench : MonoBehaviour
{
    public MonsterCard monster{get; set;}
    public int damageCount{get; set;}
    public int hp{get; set;}
    public List<ItemCard> tool{get; set;}
    public List<EnergyCard> energy{get; set;}

    public Dictionary<string, int> benchInfo{get; set;}

    public bool isPoisoned{get; set;}
    public bool isParalyzed{get; set;}
    public bool isBurned{get; set;}
    public bool isSlept{get; set;}

    public List<ImmuneType> immune {get; set;}

    // Update is called once per frame
    void Update()
    {
        UpdateDictionary();
    }

    public Bench()
    {
        monster = null;
        damageCount = 0;
        tool = new List<ItemCard>();
        energy = new List<EnergyCard>();
        benchInfo = new Dictionary<string, int>()
        {
            {"EnergyCount", 0},
            {"NormalEnergyCount", 0},
            {"SpecialEnergyCount", 0},
            {"ToolCount", 0},
            {"ConditionCount", 0}
        };

        isPoisoned = false;
        isBurned = false;
        isParalyzed = false;
        isSlept = false;
    }

    void SetDamageCount(int damageCount)
    {
        damageCount += damageCount;
    }






    void UpdateDictionary()
    {
        benchInfo["EnergyCount"] = energy.Count;
        benchInfo["NormalEnergyCount"] = ReturnCountNormalEnergy();
        benchInfo["SpecialEnergyCount"] = ReturnCountSpecialEnergy();
        benchInfo["ToolCount"] = tool.Count;
        benchInfo["ConditionCount"] = ReturnCountCondition();
    }

    int ReturnCountNormalEnergy()
    {
        
        if(energy.Count == 0)
            return 0;
        else
        {
            int c = 0;
            for(int p = 0; p < energy.Count; ++p)
            {
                if(energy[p].energyType == EnergyType.Normal)
                    c++;
            }
            return c;
        }
    }

    int ReturnHP()
    {
        return monster.hp - damageCount;
    }

    int ReturnCountSpecialEnergy()
    {
        if(energy.Count == 0)
            return 0;
        else
        {
            int c = 0;
            for(int p = 0; p < energy.Count; ++p)
            {
                if(energy[p].energyType == EnergyType.Special)
                    c++;
            }
            return c;
        }
    }

    int ReturnCountCondition()
    {
        int c = 0;

        if(isPoisoned)
            c++;
        if(isBurned)
            c++;
        if(isParalyzed)
            c++;
        if(isSlept)
            c++;

        return c;
    }
    
}
