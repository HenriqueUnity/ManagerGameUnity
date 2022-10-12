using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Script : MonoBehaviour
{
    public int day;
    private int  money, crime, heropower, totalpayday;
    public  Main_Script instance;
    [SerializeField] string scenename;
    [SerializeField] TextMeshProUGUI diatxt, heropowertxt, moneytxt;
    private NewHero hero1;
    [SerializeField] Button nextday_button;
    [SerializeField] GameObject[] localPanel;

    [Header("Lists")]
    [SerializeField] List<Locals_mainscript> mylocals = new();
    [SerializeField] List<HeroMenus> myHeroMenus = new();
    public List<NewContract> contracts = new();
    public List<NewHero>   myHeroes    = new();
    

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
           hero1 = mylocals[i].herotofight;
            if (hero1 != null)
            {
                mylocals[i].StartCrimeFight(hero1);
            }
            //mylocals[i].localcrime = mylocals[i].localcrime + 100;
            //float random =Random.Range(1, 6);
            //if(random>3)
            //{
            //    mylocals[i].localcrime += 100;
            //    Debug.Log(random);
            //}

            mylocals[i].herotofight = null;
                hero1               = null;
        }
    }
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
        day++;
       
        for(int i = 0; i < myHeroes.Count; i++)
        {
            myHeroes[i].fatigue=myHeroes[i].fatigue+1;
            myHeroes[i].checkFatigue();
        }
        TotalEconomy(); 
          TotalCrime();

        nextday_button.interactable = false;

        StartCoroutine(ButtonHide());



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
}
