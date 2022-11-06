using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade_Buttons : MonoBehaviour
{
    [SerializeField] Button[] buttonSlotUpgrade;
    [SerializeField] Main_Script MyMainScript;
    [SerializeField] Upgrademanager Myupgrademanager;
    private int currentUpgrade;
    private int currentUpgradeCost;
    private void Start()
    {
        currentUpgrade = 0;
        currentUpgradeCost = 500;
    }
    public void BuyUpgrade()
    {
        if(MyMainScript.money>=currentUpgradeCost)
        {
            buttonSlotUpgrade[currentUpgrade].interactable=false;
            if (buttonSlotUpgrade.Length>currentUpgrade+1)
            {
            buttonSlotUpgrade[currentUpgrade+1].interactable = true;
            }
            Myupgrademanager.HeroSlotUpgrade();
            currentUpgrade++;
            MyMainScript.money -= currentUpgradeCost;
            currentUpgradeCost *= 2;

        }
        
    }
    
    
}
