using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHero : MonoBehaviour
{
    [SerializeField] Heroes myHero;
    public int power, payday,cost,fatigue;
    public string heroName;
    [SerializeField] Main_Script main_Script;
    
    
    
    

    void Start()
    {
       fatigue   = myHero.fatigue;
        power    = myHero.power;
        payday   = myHero.payday;
        heroName = myHero.heroName;
        cost     = myHero.cost;

        

    }

    public void ContractHero(NewHero hero)
    {
        hero = this;

        main_Script.NewHero(hero,hero.cost);
        
    }
    
}
