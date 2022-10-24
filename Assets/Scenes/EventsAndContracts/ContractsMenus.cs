using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ContractsMenus : MonoBehaviour
{
    [SerializeField] Main_Script _mainscript;
    private int loopController;

    [SerializeField] TextMeshProUGUI contranametxt, contractmoneytxt, contractdesctxt;
    private List<NewContract> contracts = new();
   
  
    void Start()
    {
        

      UpdateNewContract();  
        MyNextContract(); 
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

    public void MyNextContract()
    {
     contranametxt.text = contracts[loopController]._contractname;
     contractdesctxt.text = "\tDescrição:\n " + contracts[loopController]._contractdescription;
     contractmoneytxt.text = "Ganhos por dia: " + contracts[loopController]._contractmoney;
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
    //TODO trocar botão de aceitar para o event panel
    

}
