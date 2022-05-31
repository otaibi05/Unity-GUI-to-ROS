using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    public InputField inputField;
    public Slider slider;
    public Text sliderText;
    public int sliderValue;
    public bool intResultTryParse;

    void Start()
    {
        inputField.onValueChanged.AddListener(delegate {ValueChange(); });
    }

    public void ValueChange()
    {
        sliderText.text = inputField.text;
        intResultTryParse = int.TryParse(inputField.text, out sliderValue);
        if (intResultTryParse == true) {
            slider.value = sliderValue;
        }
    }

    public void clearValue()
    {
        inputField.text = "";
        sliderText.text = "0";
        slider.value = 0;
    }

    void Update()
    {
        
    }
}
