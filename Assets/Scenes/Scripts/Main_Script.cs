using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class Main_Script : MonoBehaviour
{
    public  Main_Script instance;
    private NewHero hero1;

    [Header("Resources Variables")]
    public int day, money,fame;
    public int heropower, totalpayday;

    [Header("Report Variables")]
    public int ReportMoney, contractsTotalMoney;

    [Header("Strings And Text")]
    [SerializeField] string scenename;
    [SerializeField] TextMeshProUGUI diatxt, moneytxt,fameTxt;

    [Header("GameObjects")]
    [SerializeField] Button[] buttons;
    [SerializeField] GameObject[] localPanel;
    [SerializeField] EventManager eventManager;
    [SerializeField] ContractsMenus MycontractMenu;
    [SerializeField] GameObject ReportPanel;
    [SerializeField] StoreManager storeManager;

    [SerializeField] FameUpgradeButton[] fameUpgrades;
    
    
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
        moneytxt.text = $"Economia: {money}";
        fameTxt.text = $"Fama: {fame}";

       
        
    }

    public void TotalCrime()
        {

        
        for (int i = 0; i < mylocals.Count; i++)
        {

            //crime decreased 
           hero1 = mylocals[i].SetHero();
            if (hero1 != null)
            {
                mylocals[i].StartCrimeFight(hero1);
                
            }
            //crime incresead for each day
           // mylocals[i].localcrime = mylocals[i].localcrime + 100;
            //float random = Random.Range(1, 6);
            //if (random > 3)
            //{
            //    mylocals[i].localcrime += 100;

            //}


            hero1 = default;
        }
    }


    //Increased and Decreased money//
    public void TotalEconomy()
        {
        contractsTotalMoney = 0;
        ReportMoney = money;

        money -= totalpayday;


       for(int i=0; i<contracts.Count; i++)
        {
            if (contracts[i]._contractactive == true)
            {
                money += contracts[i]._contractmoney;
                contractsTotalMoney += contracts[i]._contractmoney;
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
        
       
        //Todo fatigue system new method
      
        TotalEconomy(); 
          TotalCrime();
        ResetAllLocalhero();
        UpgradesCheck();
        //Nextday Button hide for a moment
        
        StartCoroutine(ButtonHide());
        /////

        storeManager.CheckDay(day);

    }

    

    //hero bought in store move to this script List<>//
    public void NewHero(NewHero hero,int herocost)
    {
        myHeroes.Add(hero);
        money       -= herocost;
        heropower   += hero.power;
        totalpayday += hero.payday;
        fame        += hero.fame;
        storeManager.heroCount++;
        CheckContractUpgrades();
        //MycontractMenu.MyNextContract();
        

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
        GetComponent<ButtonsHide>().HideButtons();

        for (int i = 0; i < localPanel.Length; i++)
        {
            localPanel[i].SetActive(false);
        }
        ReportPanel.SetActive(true);
        ReportPanel.GetComponentInChildren<ReportScript>().ReportStats();
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
                    localhero.noheroReport = true;
                    continue;
                }
                else
                {
                    MyIds.Add(localhero.myLocalhero.heroid);
                    localhero.noheroReport = false; 
                }
            }
            switch (MyIds.Count)
            {              
                case 2:
                     repeathero = Enumerable.Equals(MyIds[0], MyIds[1]);
                    MyIds.Clear();
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
                MyIds.Clear();  
                return false;
        }
        
        MyIds.Clear();

        return false;
    }

    //check contract levels and the fame for upgrade//
    public void CheckContractUpgrades()
    {
        for(int i = 0; i < contracts.Count; i++)
        {           
             contracts[i].UpgradeCheck(fame);
        }
    }
    public void EventsDayckeck()
    {
        eventManager.EventController(day);
    }
    public void UpgradesCheck()
    {
        for(int i = 0; i < fameUpgrades.Length; i++)
        fameUpgrades[i].CheckUpgradefame();
    }
}


