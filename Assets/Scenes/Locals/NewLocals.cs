using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLocals : MonoBehaviour
{
    [SerializeField] Locals mylocal;
    public int localcrime;
    public string localname;
    void Start()
    {
      localcrime = mylocal.crime;
      localname  = mylocal.localName; 
    }

    
}
