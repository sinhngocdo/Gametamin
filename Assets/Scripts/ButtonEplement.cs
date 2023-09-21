using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEplement : MonoBehaviour
{
    [SerializeField]
    private CalculatorHandler calculator;
    [SerializeField]
    private string value;

    public void ButtonNumberPressed()
    {
        if (calculator.isOn)
        {
            calculator.SetInputValue(value);
        }
    }
}
