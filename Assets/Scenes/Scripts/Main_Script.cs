using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class Main_Script : MonoBehaviour
{
    public int day, money;
    private int   heropower, totalpayday;
    public  Main_Script instance;
    [SerializeField] string scenename;
    [SerializeField] TextMeshProUGUI diatxt, heropowertxt, moneytxt;
    private NewHero hero1;
    [SerializeField] Button nextday_button;
    [SerializeField] GameObject[] localPanel;
    [SerializeField] EventManager eventManager; 
    
    private bool repeathero, repeathero1, repeathero2, repeathero3;

    [Header("Lists")]
    [SerializeField] List<Locals_mainscript> mylocals = new();
    [SerializeField] List<HeroMenus> myHeroMenus      = new();
    public List<NewContract> contracts                = new();
    public List<NewHero>   myHeroes                   = new();
    private List<int> MyIds                           = new();



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

     

        money = 10000;


        day = 1;

    }
    private void Update()
    {
        diatxt.text   = $"Dia: {day}";
        moneytxt.text = $"Dinheiro: {money}";
        heropowertxt.text = $"Poder: {heropower}";

       
        
    }

    public void TotalCrime()
        {

        
        for (int i = 0; i < mylocals.Count; i++)
        {
           hero1 = mylocals[i].SetHero();
            if (hero1 != null)
            {
                mylocals[i].StartCrimeFight(hero1);
                
            }
            mylocals[i].localcrime = mylocals[i].localcrime + 100;
            float random = Random.Range(1, 6);
            if (random > 3)
            {
                mylocals[i].localcrime += 100;

            }


            hero1 = default;
        }
    }


    //Increased and Decreased money//
    public void TotalEconomy()
        {
        money -= totalpayday;


       for(int i=0; i<contracts.Count; i++)
        {
            if (contracts[i]._contractactive == true)
            {
                money += contracts[i]._contractmoney;
            }
            
        }
        if (money < 0)
        {
            NoMoneyGameOver();
        }

    }
    public void NextDay()
        {

        //check if can pass the day//
        bool AbletoNextDay = CheckIDS();
        Debug.Log(AbletoNextDay);
        
        if (AbletoNextDay != false)
        {
            ResetAllLocalhero();
            return;
        }
        ////////////////////////////
        day++;
        eventManager.EventController(day);
       
        //Todo fatigue system new method
      
        TotalEconomy(); 
          TotalCrime();
        ResetAllLocalhero();
        //Nextday Button hide for a moment
        nextday_button.interactable = false;
        StartCoroutine(ButtonHide());
        /////



    }

    

    //hero bought in store move to this script List<>//
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

    // player economy game over//
    private void NoMoneyGameOver()
    {
        SceneManager.LoadScene(scenename);
    }
    IEnumerator ButtonHide()
    {
        yield return new WaitForSeconds(1f);
        nextday_button.interactable =true;
        for (int i = 0; i < localPanel.Length; i++)
        {
            localPanel[i].SetActive(false);
        }
    }
    private void ResetAllLocalhero()
    {
        for (int i = 0; i < mylocals.Count; i++)
        {
            mylocals[i].myLocalhero.ResetHero();
            mylocals[i].chooseMenu.ResetHeroStats();    
        }
    }

    //chech IDs for repeat heros in locals //
    private bool CheckIDS()
    {

        if (MyIds.Count == 0)
        {
            //check ids 
            foreach (Locals_mainscript localhero in mylocals)
            {
                if (localhero.myLocalhero.heroid == 0)
                {
                    continue;
                }
                else
                {
                    MyIds.Add(localhero.myLocalhero.heroid);
                }
            }
            switch (MyIds.Count)
            {              
                case 2:
                     repeathero = Enumerable.Equals(MyIds[0], MyIds[1]);
                            break;
                case 3:
                     repeathero3 = Enumerable.Equals(MyIds[0], MyIds[1]);
                     repeathero1 = Enumerable.Equals(MyIds[1], MyIds[2]);
                     repeathero2 = Enumerable.Equals(MyIds[2], MyIds[0]);
                            break;
                default:
                    MyIds.Clear();  
                    return false;                            
             }
            if (repeathero || repeathero1 || repeathero2 || repeathero3)

            {
                MyIds.Clear();
                return true;
            }

            else

                return false;
        }
        
        MyIds.Clear();

        return true;
    }
    
}

