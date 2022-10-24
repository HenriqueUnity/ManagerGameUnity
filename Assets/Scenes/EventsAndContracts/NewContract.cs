using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewContract : MonoBehaviour, IEventInterface
{
    [SerializeField] Contract myContract;
    [SerializeField] GameObject panel;
    [SerializeField] TextMeshProUGUI contractname,contractDesc,contractValue;
    //Main_Script myMainscript;
    public string _contractname;
    public int _contractmoney,ID;
    public bool _contractactive,contractAlreadyTaken;
    public string _contractdescription;

    



    void Start()
    {

       // myMainscript         = FindObjectOfType<Main_Script>();
        ID                   = myContract.ID;
        _contractmoney       = myContract.moneycontract;
        _contractname        = myContract.contractName;
        _contractactive      = myContract.Isactive;
        _contractdescription = myContract.contractdescription;
        
        



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
}
    
