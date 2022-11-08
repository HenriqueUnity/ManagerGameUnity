using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerosSlotController : MonoBehaviour
{
    [SerializeField] GameObject[] Buttons;
    [SerializeField] Upgrademanager upgrademanager; 
    private int HeroSlots;
    void Start()
    {
        

        SlotUpgrade();
    }

   public void SlotUpgrade()
    {
        HeroSlots = upgrademanager.heroSlotsCapacity;
        for (int i = 0; i < HeroSlots; i++)
        {
            Buttons[i].SetActive(true);
        }
    }
}
