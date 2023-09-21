using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownHandler : MonoBehaviour
{
    [SerializeField]
    private float timeValue;

    [SerializeField]
    private TextMeshProUGUI timeCountDownText;

    [SerializeField]
    GameObject imageCover;

    public bool isPlayedAds = false;

    private void Start()
    {
        HideRunTimeCountDownImageCover();
    }

    public void StartRunTimeCountDown()
    {
        timeCountDownText.gameObject.SetActive(true);
        imageCover.SetActive(true);
        isPlayedAds = true;
    }

    void HideRunTimeCountDownImageCover()
    {
        timeCountDownText.gameObject.SetActive(false);
        imageCover.SetActive(false);
        isPlayedAds = false;
    }

    private void Update()
    {
        if (isPlayedAds)
        {
            RunTime();
        }
    }

    void RunTime()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            HideRunTimeCountDownImageCover();
        }

        DisplayTime(timeValue);
    }


    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if(timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeCountDownText.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
