using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject calculator;
    public GameObject uiShopObject;
    public GameObject uiMenu;
    

    
    public void OnOpenCalculator()
    {
        calculator.SetActive(true);
        uiMenu.SetActive(false);
    }


    public void OnOpenShop()
    {
        uiShopObject.SetActive(true);
        uiMenu.SetActive(false);
    }

    public void OnOpenMenu()
    {
        uiMenu.SetActive(true);
        calculator.SetActive(false);
        uiShopObject.SetActive(false);
    }

}
