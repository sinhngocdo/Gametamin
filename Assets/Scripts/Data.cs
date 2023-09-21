using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Data : MonoBehaviour
{
    [SerializeField]
    private int amountCoin;

    [SerializeField]
    private TextMeshProUGUI amountCoinTxt;

    public static Data instance;

    private void Awake()
    {
        instance = this;
    }



    private void Start()
    {
        amountCoin = PlayerPrefs.GetInt("dataCoin");
        amountCoinTxt.text = amountCoin.ToString();
    }


    public void AddCoin(int amount)
    {
        amountCoin += amount;
        PlayerPrefs.SetInt("dataCoin", amountCoin);
        amountCoinTxt.text = amountCoin.ToString();
    }
}
