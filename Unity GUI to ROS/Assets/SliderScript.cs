using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;

    void Start()
    {
        slider.onValueChanged.AddListener((v) => {
            sliderText.text = v.ToString("0");
        });
    }

    void Update()
    {
        
    }
}
