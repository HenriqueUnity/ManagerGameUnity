using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_button : MonoBehaviour
{
    public bool AlreadyBuy;
    Button myButton;
    [SerializeField] GameObject myText;

    private void Start()
    {
         myButton = GetComponent<Button>();   
    }
    public void BuyConfirm()
    {
        AlreadyBuy = true;
        myButton.interactable = false;
        myText.SetActive(true);
        
    }
    
    public void CanBuyAgain()
    {
        myButton.interactable = true;
        AlreadyBuy = false;
        myText.SetActive(false);
    }
    public void NoSlotsLeft()
    {
        myButton.interactable = false;
    }
    
}
