using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class NewHero : MonoBehaviour
{
    [SerializeField] Heroes myHero;
    public int power, payday, cost ,Id,fame;
    public string heroName;
    [SerializeField] Main_Script main_Script;
    public SpriteRenderer HeroImage;
    void Start()
    {
        
        power    = myHero.power;
        payday   = myHero.payday;
        heroName = myHero.heroName;
        cost     = myHero.cost;
        Id       = myHero.id;
        fame     = myHero.fame;
        

    }
   

    public void ContractHero(NewHero hero)
    {
        hero = this;

        main_Script.NewHero(hero,hero.cost);
        
        
    }
   
    
}
