using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ContractsMenus : MonoBehaviour
{
    [SerializeField] Main_Script _mainscript;
    private int loopController = 0;
    private int Payday;

    [SerializeField] TextMeshProUGUI payDayTxt;

    [Header("Contract Elements")]
    [SerializeField] TextMeshProUGUI contranametxt, contractmoneytxt, contractdesctxt,levelTxt;
    private List<NewContract> contracts = new();
  
    void Start()
    {
        

      UpdateNewContract();  
        MyNextContract(); 
        EconomicStats();
    }

    
    
    public void EconomicStats()
    {
        Payday = _mainscript.totalpayday;
        payDayTxt.text = $"Pagamento dos heróis: R$:{Payday}"; 
    }
    public void  UpdateNewContract()
    {
        for (int i = 0; i < _mainscript.contracts.Count; i++)
        {
        if (_mainscript.contracts[i]._contractactive && _mainscript.contracts[i].contractAlreadyTaken == false)
        {
         _mainscript.contracts[i].contractAlreadyTaken = true;
         contracts.Add(_mainscript.contracts[i]);
        }
        }
    }


    //function for nextcontract Button,show and hide all active contracts
    public void MyNextContract()
    {
     contranametxt.text    = contracts[loopController]._contractname;
     contractdesctxt.text  = $"Descrição: {contracts[loopController]._contractdescription}";
     contractmoneytxt.text = $"Ganhos por dia: {contracts[loopController]._contractmoney}";
     levelTxt.text         = $"Level: {contracts[loopController].level}"; 
     loopController++;
      
        if(contracts.Count == 1)
        {
          loopController =0;
        }
        if(loopController > contracts.Count)
        {
            loopController = 0; 
        }
        if(loopController == contracts.Count)
        {
            loopController = 0;
        }

        
    }
    
    

}
