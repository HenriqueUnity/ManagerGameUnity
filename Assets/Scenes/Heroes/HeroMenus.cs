using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HeroMenus : MonoBehaviour
{
    public  List<NewHero> hero=new List<NewHero>();
    [SerializeField]TextMeshProUGUI nametxt, powertxt, paydaytxt;

    void Start()
    {
       
        
    }

    
    void Update()
    {
        

        foreach(NewHero hero in hero)
        {
            nametxt.text = "Nome: " + hero.heroName;
           powertxt.text = "Poder: " + hero.power.ToString();
           paydaytxt.text = "Salário: " + hero.payday.ToString();
        }
    }
    
}
