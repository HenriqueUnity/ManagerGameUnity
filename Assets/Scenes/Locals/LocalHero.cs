using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalHero : MonoBehaviour
{
    [SerializeField] NewHero localhero1;
    [SerializeField] GameObject chooseMenus;
    
    private void Awake()
    {
      
        
    }
    public void GetHero(NewHero localhero)
    {
        localhero1 = localhero;
        
    }   
    public NewHero SetHero()
    {
        return localhero1;
    }

    public void ChooseHero()
    {
        if (chooseMenus.activeInHierarchy)
        {
            chooseMenus.SetActive(false);
         
        }
        else
        {
            chooseMenus.SetActive(true);  
          
        }

    }
    public void HeroChoose(NewHero hero)
    {
        localhero1 = hero;   
    }
    
}
