using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiShopHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject uiNormalShop;
    [SerializeField]
    private GameObject uiExpandedShop;


    private void Start()
    {
        OnHideExpandedShop();
    }


    public void OnHideExpandedShop()
    {
        uiNormalShop.SetActive(true);
        uiExpandedShop.SetActive(false);
    }

    public void OnShowExpandedShop()
    {
        uiExpandedShop.SetActive(true);
        uiNormalShop.SetActive(false);
    }
}
