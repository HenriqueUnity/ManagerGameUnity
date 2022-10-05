using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main_Script : MonoBehaviour
{
    private int day, money,crime,heropower;

    [SerializeField] List<NewHero> myHeroes= new List<NewHero>();
    [SerializeField] TextMeshProUGUI diatxt, heropowertxt, moneytxt;
    public  Main_Script instance;

    private void Start()
    {
        money = 50000;
        instance = this;



      
       

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
        //todo sistema turno
        }
    public void NewHero(NewHero hero,int herocost)
    {
        myHeroes.Add(hero);
        money     -= herocost;
        heropower += hero.power;
    }
}
