using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShopPopup : MonoBehaviour
{
    public Animator animator;
    public GameObject uiMenu;


    public void OnHideUI(string animName)
    {
        animator.Play(animName);
        uiMenu.SetActive(true);
    }

    public void HideShopEvent()
    {
        gameObject.SetActive(false);
    }
}
