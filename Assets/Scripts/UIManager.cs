using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject calculator;
    [SerializeField]
    private GameObject uiShopObject;
    [SerializeField]
    private GameObject uiMenu;


    private void Start()
    {
        OnHideShopAndCalculator();
    }

    public void OnOpenCalculator()
    {
        calculator.SetActive(true);
        uiMenu.SetActive(false);
    }

    void OnHideShopAndCalculator()
    {
        uiShopObject.SetActive(false);
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
