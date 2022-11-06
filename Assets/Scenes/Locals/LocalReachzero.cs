using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalReachzero : MonoBehaviour
{
    private Locals_mainscript Mylocal;
    private Main_Script Mymains_script;
    private int fameUpgrade;
    
    public void LocalHasReachZero()
    {
        Mylocal = GetComponentInParent<Locals_mainscript>();
        fameUpgrade = Mylocal.fameUpgrade;
        Mylocal.LocalReachZero = false;
        Mymains_script = FindObjectOfType<Main_Script>();
        Mymains_script.fame += fameUpgrade;
        
        for(int i = 0; i < Mymains_script.contracts.Count; i++)
        {
            Mymains_script.contracts[i].UpgradeCheck(Mymains_script.fame);
        }
        gameObject.SetActive(false);    
        
    }
}
