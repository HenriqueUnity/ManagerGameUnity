using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrademanager : MonoBehaviour
{
    [SerializeField] StoreManager myStore;
    [SerializeField] Main_Script myMain_Script;
     public int heroSlotsCapacity;
    

    void Start()
    {
        heroSlotsCapacity = 2;
    }
    public void HeroSlotUpgrade()
    {

        heroSlotsCapacity ++;
        myStore.ActiveButtons();
    }
    //public void FameUpgrade()
    //{
    //    switch(fameUpgradeStats)
    //    {
    //        case 0:
    //            myMain_Script.fame += 50;
    //            fameUpgradeStats++;
    //            break;
    //            case 1:
    //            myMain_Script.fame += 85;
    //            fameUpgradeStats++;
    //            break;
    //        case 2:
    //            myMain_Script.fame += 125;
    //            fameUpgradeStats++;
    //            break;  
    //    }
    //}
}
