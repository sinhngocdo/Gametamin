using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public CalculatorHandler calculator;
    public string value;

    public void ButtonNumberPressed()
    {
        if (calculator.isOn)
        {
            calculator.SetInputValue(value);
        }
    }
}
