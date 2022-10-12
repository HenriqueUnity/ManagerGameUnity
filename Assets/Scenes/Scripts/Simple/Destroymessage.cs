using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroymessage : MonoBehaviour
{
    public static Destroymessage instance;
   
    void Start()
    {
        if(instance != null && instance !=this)
        {
            Destroy(gameObject);
        }
        else
            instance = this;
       

       Destroy(gameObject,2); 
    }

    
}
