using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main_Script : MonoBehaviour
{
    private int day, money, crime, heropower, totalpayday;

    public List<NewHero>   myHeroes    = new();
    [SerializeField] List<HeroMenus> myHeroMenus = new();
    [SerializeField] TextMeshProUGUI diatxt, heropowertxt, moneytxt;
    public  Main_Script instance;
    [SerializeField] List<Locals_mainscript> mylocals = new();

    private void Start()
    {
     if(instance != null && instance !=this)
        {
            Destroy(gameObject);
        }
     else
        {
        instance = this;
        }

     DontDestroyOnLoad(gameObject); 

        money = 50000;
               
           
     

    }
    private void Update()
    {
        diatxt.text   = $"Dia: {day}";
        moneytxt.text = $"Dinheiro: {money}";
        heropowertxt.text = $"Poder: {heropower}";
    }

    public void TotalCrime()
        {
        //TODO sistema crime
        }
    public void TotalEconomy()
        {
        //TODO sistema dinheiro
        }
    public void NextDay()
        {
        day++;
        money -= totalpayday;

        for(int i = 0; i < myHeroes.Count; i++)
        {
            myHeroes[i].fatigue=myHeroes[i].fatigue+1;
        }
       for(int i = 0; i < mylocals.Count; i++)
        {
            mylocals[i].localcrime =mylocals[i].localcrime+100;
        }
        }
    public void NewHero(NewHero hero,int herocost)
    {
        myHeroes.Add(hero);
        money       -= herocost;
        heropower   += hero.power;
        totalpayday += hero.payday;
        for(int i=0;i<myHeroMenus.Count;i++)
        {
            if (myHeroMenus[i].checkhero == false)
            {
                myHeroMenus[i].NewHeroStats(hero);
               
                
                break;
            }
        }
    }
}
