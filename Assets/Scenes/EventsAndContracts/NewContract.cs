using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class NewContract : MonoBehaviour
{
    [SerializeField] Contract myContract;
    public string _contractname,completdescp;
    public int _contractmoney;
    public bool _contractactive;
    public string[] _contractdescription;
    private int contractsize;
    
    
    void Start()
    {
        _contractmoney       = myContract.moneycontract;
        _contractname        = myContract.contractName;
        _contractactive      = myContract.Isactive;
        contractsize         = myContract.contractdescription.Length;
        _contractdescription = new string[contractsize];    
        _contractactive      = false;
        
        for(int i = 0; i < myContract.contractdescription.Length; i++)
            {
            _contractdescription[i] = myContract.contractdescription[i];
        }
        foreach (string contracstring in _contractdescription)
        {
            completdescp += " " + contracstring;
        }
       
    }
    public void AcceptContract()
    {
        _contractactive=true;
    }

}
    
