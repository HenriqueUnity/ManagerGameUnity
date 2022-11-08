using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FameUpgradeButton : MonoBehaviour
{
    [SerializeField] Button myButton;
    [SerializeField] Main_Script myMainscript;
    [SerializeField] int upgradeCost;
    bool upgradeActive;

    public void FameUpgrade()
    {
     if(myMainscript.money > upgradeCost)
        {
            myMainscript.money -= upgradeCost;
            myButton.interactable = false;
            upgradeActive = true;
         }
     }
    public void CheckUpgradefame()
    {
        if(upgradeActive)
        GetComponent<FameUpgrades>().FameUpgrade();
    }
    
}
