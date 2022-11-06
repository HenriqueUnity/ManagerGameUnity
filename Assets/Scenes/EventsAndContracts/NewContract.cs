using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewContract : MonoBehaviour, IEventInterface
{
    [SerializeField] Contract        myContract;
    [SerializeField] GameObject      panel;
    [SerializeField] TextMeshProUGUI contractname,contractDesc,contractValue;
    [SerializeField] int[] moneyUpgrade;
    
    //Main_Script myMainscript;
    public string _contractname;
    public int _contractmoney, ID;
    public bool   _contractactive,contractAlreadyTaken;
    public string _contractdescription;
    public int[]  fameToUpgrade;
    public int level = 1;
    

    



    void Start()
    {

       // myMainscript         = FindObjectOfType<Main_Script>();
        ID                   = myContract.ID;
        _contractmoney       = myContract.moneycontract;
        _contractname        = myContract.contractName;
        _contractactive      = myContract.Isactive;
        _contractdescription = myContract.contractdescription;


        fameToUpgrade = new int[myContract.fameForUpgrade.Count];

        for (int i = 0; i < myContract.fameForUpgrade.Count; i++)
        {
           fameToUpgrade[i] = myContract.fameForUpgrade[i];                                      
        }

        
        



    }
    
    
    public void StatusIncreased()
    {
       _contractactive = true;
        
    }

    public void OpenPanel(GameObject t)
    {
        panel.SetActive(true);
        contractname.text  = _contractname;
        contractDesc.text  = _contractdescription;
        contractValue.text = $"Valor:{_contractmoney}";
        
    }
    
    public void UpgradeCheck(int fame)
    {
        switch(level)
        {
            case 1:
                if (fameToUpgrade[0] <=fame)
                {
                    level = 2;
                    _contractmoney += moneyUpgrade[0]; 
                    
                }
                break;
            case 2:
                if(fameToUpgrade[1] <=fame)
                {
                    level = 3;
                    _contractmoney += moneyUpgrade[1];
                }
                break;
                default:
                break;                               
        }
    }
}
    
