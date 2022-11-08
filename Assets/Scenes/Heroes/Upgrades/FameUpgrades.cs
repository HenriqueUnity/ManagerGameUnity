using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FameUpgrades : MonoBehaviour
{
    [SerializeField] int fameforEachTurn;
    [SerializeField] Main_Script myMainScript;
    public string NetworkName;

    public void FameUpgrade()
    {
        myMainScript.fame += fameforEachTurn;
    }
}
