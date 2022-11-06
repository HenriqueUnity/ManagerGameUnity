using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsHide : MonoBehaviour
{
    [SerializeField] Button[] myButtons;  
    public void HideButtons()
    {
        for (int i = 0; i < myButtons.Length; i++)
        {
            myButtons[i].interactable = false;
        }
    }
    public void ShowButtons()
    {

        for (int i = 0; i < myButtons.Length; i++)
        {
            myButtons[i].interactable = true;
        }
    }
}
