using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;

public class CalculatorHandler : MonoBehaviour
{
    private float number1;
    private float number2;
    private string option;

    [SerializeField]
    private TextMeshProUGUI screenText;
    [SerializeField]
    private TextMeshProUGUI operatorText;

    public GameObject screenCalculator;

    public bool isOn = false;


    // Start is called before the first frame update
    void Start()
    {
        
        OFFButton();

        
    }




    void ResetAll()
    {
        screenText.text = "0";
        operatorText.text = "";
        number1 = 0f;
        number2 = 0f;
        option = "";
    }

    public void OnButton()
    {
        isOn = true;
        transform.GetChild(0).gameObject.SetActive(true);
        screenCalculator.GetComponent<Image>().color = new Color32(165, 166, 85, 255);
    }

    public void OFFButton()
    {
        isOn = false;
        ResetAll();
        transform.GetChild(0).gameObject.SetActive(false);
        screenCalculator.GetComponent<Image>().color = new Color32(100, 100, 100, 255);
    }

    public void CButton()
    {
        ResetAll();
    }

    public void SetInputValue(string buttonValue)
    {
        //Clear fields if _input contains letters
        if (screenText.text.ToString().Any(x => char.IsLetter(x)))
        {
            ResetAll();
        }

        //Handles button input values
        switch (buttonValue)
        {
            case "+":
                operatorText.text = "+";
                Calculate(buttonValue);
                break;
            case "-":
                operatorText.text = "-";
                Calculate(buttonValue);
                break;
            case "*":
                operatorText.text = "*";
                Calculate(buttonValue);
                break;
            case "/":
                operatorText.text = "/";
                Calculate(buttonValue);
                break;
            case "=":
                Calculate(buttonValue);
                break;
            default:
                AddCharacter(buttonValue);
                break;
        }
    }

    private void Calculate(string buttonValue)
    {
        //If screen field is empty
        if (buttonValue != "=")
        {
            try
            {
                number1 = Convert.ToSingle(screenText.text);
            }
            catch (FormatException)
            {
                // The string is not in a valid float format.
                ResetAll();
                screenText.text = "Invalid input";
                return;
            }
            //screenText.text = "";
            option = buttonValue;
            screenText.text = screenText.text + " " + buttonValue;
            screenText.text = "";
            return;
        }

        //Handles division by 0
        if (option == "/" && screenText.text == "0")
        {
            ResetAll();
            screenText.text = "Cannot divide by zero";
            return;
        }

        //Calculates float result
        
        try
        {
            number2 = Convert.ToSingle(screenText.text);
        }
        catch (FormatException)
        {
            // The string is not in a valid float format.
            ResetAll();
            screenText.text = "Invalid input";
            return;
        }

        if (buttonValue == "=")
        {
            screenText.text = screenText.text;
            screenText.text = CalculatePair(number1, number2, option).ToString("f");
        }
        else
        {
            number1 = Convert.ToSingle(CalculatePair(number1, number2, option));
            screenText.text = number1.ToString() + " " + buttonValue;
            option = buttonValue;
        }
    }

    //Return the result of an operation between 2 floats
    private float CalculatePair(object x, object y, object op)
    {
        float result = 0.0f;

        switch (op)
        {
            case "+":
                result = number1 + number2;
                break;
            case "-":
                result = number1 - number2;
                break;
            case "*":
                result = number1 * number2;
                break;
            case "/":
                result = number1 / number2;
                break;
        }

        return result;
    }


    //Add character input to input text string
    private void AddCharacter(string buttonValue)
    {
        //Add only one decimal point
        if (buttonValue == ".")
        {
            if (!screenText.text.ToString().Contains("."))
            {
                screenText.text += buttonValue;
            }
            //Remove 0 in front of number
        }
        else if (screenText.text == "0")
        {
            screenText.text = buttonValue;
            //Concatenate the input string
        }
        else
        {
            screenText.text += buttonValue;
        }
    }
}
