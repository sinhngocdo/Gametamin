using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShopPopup : MonoBehaviour
{
    public Animator animator;
    public GameObject uiMenu;
    public GameObject uiNormalShop;
    public GameObject uiExpandedShop;





    private void Start()
    {
        OnHideExpandedShop();
    }



    public void OnHideUI(string animName)
    {
        animator.Play(animName);
        uiMenu.SetActive(true);
    }

    public void HideShopEvent()
    {
        gameObject.SetActive(false);
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
