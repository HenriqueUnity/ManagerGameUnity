using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalHero : MonoBehaviour
{
    public NewHero localhero1;
    [SerializeField] GameObject chooseMenus;
    public int heroid;
    
  
    public void GetHero(NewHero localhero)
    {
        localhero1 = localhero;
        
    }   
    public NewHero SetHero()
    {
        
        return localhero1;
    }
    public int GetId()
    {
        heroid = localhero1.Id;

        return heroid;
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
    public void ResetHero()
    {
         localhero1 = null;
             heroid = 0;
    }
    
}
