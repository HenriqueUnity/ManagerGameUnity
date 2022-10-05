using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenCloseTabs : MonoBehaviour
{
    [SerializeField] GameObject Tabtoopenclose;

    
    public void OpenAndClose()
    {
     if(Tabtoopenclose.activeInHierarchy)
        {
            Tabtoopenclose.SetActive(false);    
        }
        else
        {
            Tabtoopenclose.SetActive(true); 
        }
    }
}
