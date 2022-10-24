using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Contract",menuName ="New Contract/contract")]
public class Contract : ScriptableObject
{
    public int moneycontract,ID;
    public string contractName;
    public bool Isactive=false;
    public string contractdescription;
   
    
}
