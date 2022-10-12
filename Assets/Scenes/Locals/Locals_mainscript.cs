using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Locals_mainscript : MonoBehaviour
{
    public NewHero herotofight;
    [SerializeField]NewLocals mylocal;
    public int localcrime;
    [SerializeField] TextMeshProUGUI crimetxt, nametxt;
    private LocalHero myLocalhero;
    bool firststart=true;
    [SerializeField] GameObject messageerro;
    [SerializeField] RectTransform posicaomensagem;
    [SerializeField] Locals_mainscript[] checkOtherLocals;
    
    
   

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
    public void SetHero()
    { 
            herotofight = myLocalhero.SetHero();
        for (int i = 0; i < checkOtherLocals.Length; i++)
        {

        }
        
        {
        if (herotofight == null)
         {
            Instantiate(messageerro,posicaomensagem);
                
         }
        //else if (herotofight.fatigue >= 1)
        //     {
        //        StartCrimeFight(herotofight);
        //     }
        }
        
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
}
