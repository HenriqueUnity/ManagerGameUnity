using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContractsMenus : MonoBehaviour
{
    private Main_Script _mainscript;

    [SerializeField] TextMeshProUGUI[] contranametxt, contractmoneytxt, contractdesctxt;
    private List<NewContract> contracts = new();
   
  
    void Start()
    {
        _mainscript = FindObjectOfType<Main_Script>();

        for (int i = 0; i < _mainscript.contracts.Count; i++)
        {
            contracts.Add(_mainscript.contracts[i]);
        }

    }
    private void Update()
    {
        for (int i = 0; i < contracts.Count; i++)
        {
            contranametxt[i].text = contracts[i]._contractname;
            contractdesctxt[i].text = "\tDescrição:\n " + contracts[i].completdescp;
            contractmoneytxt[i].text = "Ganhos por dia: " + contracts[i]._contractmoney;
            

        }
        
    }

    

}
