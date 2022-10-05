using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main_Script : MonoBehaviour
{
    private int day, money,crime,heropower;

  [SerializeField] List<NewHero> myHeroes= new List<NewHero>();
    [SerializeField] TextMeshProUGUI diatxt, heropowertxt, moneytxt;

    private void Start()
    {
        diatxt.text   = $"Dia: {day}";
        moneytxt.text = $"Dinheiro: {money}";

      foreach(NewHero hero in myHeroes)
        {
            heropower += hero.power;
        }
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
}
