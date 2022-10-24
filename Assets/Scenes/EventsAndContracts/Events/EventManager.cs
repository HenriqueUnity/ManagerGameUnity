using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [Header("Lists")]
    [SerializeField] List<EventCrime> myEventsCrime = new();
    [SerializeField] List<NewContract> myContracts  = new();

    [Header("Atributes")]
    [SerializeField] GameObject EventPanel;
    [SerializeField] ContractsMenus MycontractMenu;

    public void EventController(int day)
    {
        switch (day)
        {
            case 5:
                for (int i = 0; i < myContracts.Count; i++)
                {
                    bool eventStart = myContracts[i].ID == 2;
                    if(eventStart)
                    {
                        myContracts[i].OpenPanel(EventPanel);
                        myContracts[i].StatusIncreased();
                        MycontractMenu.UpdateNewContract();
                        
                    }
                }
                break;
            case 7:
            for (int i = 0; i < myEventsCrime.Count; i++)
            {
                bool eventStart = myEventsCrime[i].id == 1;
                if (eventStart)
                {
                    {
                        myEventsCrime[i].OpenPanel(EventPanel);
                        myEventsCrime[i].StatusIncreased();
                    }
                }
            }
                break;
            case 9:
                for (int i = 0; i < myContracts.Count; i++)
                {
                    bool eventStart = myContracts[i].ID == 3;
                    if (eventStart)
                    {
                        myContracts[i].OpenPanel(EventPanel);
                        myContracts[i].StatusIncreased();
                        MycontractMenu.UpdateNewContract();

                    }
                }

                break;
            case 13:
                for (int i = 0; i < myEventsCrime.Count; i++)
                {
                    bool eventStart = myEventsCrime[i].id == 2;
                    if (eventStart)
                    {
                        {
                            myEventsCrime[i].OpenPanel(EventPanel);
                            myEventsCrime[i].StatusIncreased();
                        }
                    }
                }
                break;
            default:
                
                break;
        }
    }
    //TODO dias para surgir contratos e sistema para aceitalos 
}
