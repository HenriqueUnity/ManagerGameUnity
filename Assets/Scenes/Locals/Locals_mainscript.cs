using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Locals_mainscript : MonoBehaviour
{
    
    [SerializeField]NewLocals mylocal;
    public int localcrime,fameUpgrade;
    [SerializeField] TextMeshProUGUI crimetxt, nametxt;
    public LocalHero myLocalhero;
    public string localName;
    bool firststart=true;
    [SerializeField] GameObject messageerro;
    [SerializeField] RectTransform posicaomensagem;
    public HeroChooseMenus chooseMenu;

    public bool LocalReachZero;

    [Header("Report Variables")]
    public int heroPowerReport, localCrimeReport;
    public bool noheroReport =false;
    public string heroName;
    
    


    void Start()
    {
        myLocalhero = GetComponentInChildren<LocalHero>();    
        
        
    }

    
    void Update()
    {
        if (firststart)
        {
            localcrime   = mylocal.localcrime;
            nametxt.text = mylocal.localname;
            firststart   = false;  
            localName    = mylocal.localname;
            localCrimeReport = localcrime;
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
        localCrimeReport = localcrime;
        heroPowerReport  = herotofight.power;
        heroName = herotofight.heroName;

        localcrime      -= herotofight.power;
        if(localcrime <= 0)
        {
            localcrime = 0;
            LocalReachZero = true;
            GetComponentInChildren<LocalReachzero>().LocalHasReachZero();
        }
    }
   public void CallSetHero()
    {
        myLocalhero.localhero1 = SetHero(); 
    }
    
}
