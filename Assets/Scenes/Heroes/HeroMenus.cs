using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class HeroMenus : MonoBehaviour
{
    public NewHero hero;
    [SerializeField]TextMeshProUGUI nametxt, powertxt, paydaytxt,costtxt;
    [SerializeField] bool inStore;
    public bool checkhero;
    private Main_Script main_Script;
    private int i=0;
    [SerializeField]LocalHero _LocalHero;
    void Start()
    {
      
       if(inStore)
        {
            checkhero=true; 
        }
        main_Script = FindObjectOfType<Main_Script>();
        _LocalHero = GetComponentInParent<LocalHero>();
        
    }


    void Update()
    {
        //i = 4 limitador de herois no momento//
        if (i == 4)
        {
            i = 0;
        }

        if (hero == null)
        {
            checkhero = false;
        }
        else
        {
            checkhero = true;
        }

        if (checkhero)
        {
            nametxt.text = "Nome: " + hero.heroName;
            powertxt.text = "Poder: " + hero.power.ToString();
            paydaytxt.text = "Salário: " + hero.payday.ToString();
            if (inStore)
            {
                costtxt.text = $"Valor: {hero.cost}";
            }
        }

    }

          public void NewHeroStats(NewHero newhero)
            {
            hero = newhero;
            checkhero = true;
            }

           public void NewHeroChoose()
            {
                    
        switch(i)

            {
            case 0 :
                if (main_Script.instance.myHeroes.Any())
                {                                                  
                    hero = main_Script.instance.myHeroes[0];
                    i++;
                    _LocalHero.GetHero(hero);
                }
                break;
            case 1 :
                if (main_Script.instance.myHeroes.Count>1)
                {
                    hero = main_Script.instance.myHeroes[1];
                    i++;
                    _LocalHero.GetHero(hero);
                    if (main_Script.instance.myHeroes.Count == 2) 
                    {
                        i = 0;
                    }
                }
                else
                    i = 0;  
               
                break;
            case 2 :
                if (main_Script.instance.myHeroes.Count > 2)
                {
                    hero = main_Script.instance.myHeroes[2];
                    i++;
                    _LocalHero.GetHero(hero);
                    if (main_Script.instance.myHeroes.Count == 3) 
                    {
                        i = 0;
                    }
                }
                else
                    i = 0;
                

                break;
            case 3:
                if (main_Script.instance.myHeroes.Count > 3)
                {
                    hero = main_Script.instance.myHeroes[3];
                    i++;
                    _LocalHero.GetHero(hero);
                    if (main_Script.instance.myHeroes.Count == 4) 
                    {
                        i = 0;
                    }
                }
                else
                    i = 0;
                 
                break;

             }
           
           }
    
}






