using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class StoreManager : MonoBehaviour
{
   
    [SerializeField] List<HeroMenus> myHeroMenus; 
    [SerializeField] NewHero[] newHero;

    private int scenarioid;

    [Header("Upgrade elements")]
    public int heroSlots;
    public int heroCount;   
    [SerializeField]Upgrademanager upgradeManager;



    [Header("Game Objects")]
    [SerializeField] GameObject Heromenu;
    [SerializeField] GameObject NewheroMenu;
    [SerializeField] Store_button[] buy_button;
    [SerializeField] GameObject[] buy_Text;

    
    void Start()
    {
        
        scenarioid = Random.Range(1, 4);
        Debug.Log(scenarioid);
        StoreHeroChanges();
        
    }
    private void Update()
    {
        heroSlots = upgradeManager.heroSlotsCapacity;

        if(heroSlots == heroCount)
        {
           DeactiveButtonForNoSlots();
        }

    }


    public void CheckDay(int day)
    {
        if (day == 3)
        {
            int newScenarioid = Random.Range(1, 4);
            while(newScenarioid == scenarioid)
            {
                newScenarioid = Random.Range(1, 4);
            }
            scenarioid = newScenarioid;
            ActiveButtonsForNewStore();

            StoreHeroChanges();
        }
    }
    private void DeactiveButtonForNoSlots()
    {
       if( heroSlots == heroCount)
        {
            {
                for (int i = 0; i < buy_button.Length; i++)
                {
                    buy_button[i].NoSlotsLeft();
                }
            } }
    }
    //public void DeactivateButtons()
    //{
    //    for (int i = 0; i < buy_button.Length; i++)
    //    {
    //        if (buy_button[i].AlreadyBuy)
    //        {
    //            buy_button[i].BuyConfirm();
    //        }
    //    }
    //}
    public void ActiveButtons()
    {
        for (int i = 0; i < buy_button.Length; i++)
        {
            if(buy_button[i].AlreadyBuy == false)
            {
               buy_button[i].CanBuyAgain();
            }
        }
       
    }
    public void ActiveButtonsForNewStore()
    {
        for (int i = 0; i < buy_button.Length; i++)
        {
                      
                buy_button[i].CanBuyAgain();
            
        }
       
    }

    //public void CheckDay()
    //{
    //    switch(myMainScript.day)
    //    {
    //        case 3:StoreHeroChanges(); break;
    //            case 6:StoreHeroChanges(); break;
    //        case 8: StoreHeroChanges(); break;
    //        case 11: StoreHeroChanges(); break;
    //        case 13: StoreHeroChanges(); break;
    //        case 20: StoreHeroChanges(); break;
    //            default:
    //            break;
    //    }
    //}

    private void StoreHeroChanges()
    {
        switch (scenarioid)
        {
            case 1:
                myHeroMenus[0].hero = newHero[0];
                myHeroMenus[1].hero = newHero[1];
                myHeroMenus[2].hero = newHero[2];
                myHeroMenus[3].hero = newHero[3];
                break;
            case 2:
                myHeroMenus[0].hero = newHero[4];
                myHeroMenus[1].hero = newHero[5];
                myHeroMenus[2].hero = newHero[6];
                myHeroMenus[3].hero = newHero[7];
                break;
            case 3:
                myHeroMenus[0].hero = newHero[1];
                myHeroMenus[1].hero = newHero[3];
                myHeroMenus[2].hero = newHero[5];
                myHeroMenus[3].hero = newHero[7];
                break;
        }
    }

   
    
}
