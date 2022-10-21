using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventCrime : MonoBehaviour,IEventInterface

{
    [SerializeField] CrimeDayEvent _CrimeDayEvent;    
    [SerializeField] Locals_mainscript mylocals;
    [SerializeField] TextMeshProUGUI eventNametxt, desctxt;
    public int                   id;
    private int      crimeIncreased;

    [Header("Text Elements")]
    public string    description, eventName;

    void Start()
    {
        crimeIncreased = _CrimeDayEvent.crimeIncreased;
        id             = _CrimeDayEvent.id;
        description    = _CrimeDayEvent.crimeEventDesc;
        eventName      = _CrimeDayEvent.eventName;
    }

    public void StatusIncreased()
    {

        mylocals.localcrime += crimeIncreased;

    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        eventNametxt.text = eventName;
        desctxt.text      = description;
    }
}
