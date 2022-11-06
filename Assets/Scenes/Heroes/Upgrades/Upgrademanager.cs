using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrademanager : MonoBehaviour
{
    public int heroSlotsCapacity;
    [SerializeField] StoreManager myStore;

    void Start()
    {
        heroSlotsCapacity = 2;
    }
    public void HeroSlotUpgrade()
    {

        heroSlotsCapacity ++;
        myStore.ActiveButtons();
    }
}
