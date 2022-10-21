using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Locals_mainscript : MonoBehaviour
{
    
    [SerializeField]NewLocals mylocal;
    public int localcrime;
    [SerializeField] TextMeshProUGUI crimetxt, nametxt;
    public LocalHero myLocalhero;
    bool firststart=true;
    [SerializeField] GameObject messageerro;
    [SerializeField] RectTransform posicaomensagem;

    
    


    void Start()
    {
        myLocalhero = GetComponentInChildren<LocalHero>();    

    }

    
    void Update()
    {
        if (firststart)
        {
            localcrime = mylocal.localcrime;
            nametxt.text = mylocal.localname;
            firststart=false;   
        }
            crimetxt.text = $"Crime local: {localcrime}";
       
    }
    //Set do hero que vai lutar no local
    public NewHero SetHero()
    {


       return myLocalhero.SetHero();
        

    }  
    //Crime - HeroPower
    public void StartCrimeFight(NewHero herotofight)
    {
        herotofight.fatigue -= 1;
        localcrime -= herotofight.power;
        if(localcrime < 0)
        {
            localcrime = 0;
        }
    }
   public void CallSetHero()
    {
        SetHero();
    }
}
