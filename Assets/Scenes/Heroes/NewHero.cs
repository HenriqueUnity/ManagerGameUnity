using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHero : MonoBehaviour
{
    [SerializeField] Heroes myHero;
    public int power, payday;
    public string heroName;

    void Start()
    {
        power = myHero.power;
        payday= myHero.payday;
        heroName = myHero.heroName;

        

    }
    
}
