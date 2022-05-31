using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.UnityRoboticsDemo;

public class RosPublisher : MonoBehaviour
{
    ROSConnection ros;
    public string topicName;
    public InputField inputField;
    public Slider slider;
    public int value;
    public bool intResultTryParse;

    void Start()
    {
        topicName = "number_to_unity";
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<ValueMsg>(topicName);
        // inputField.onValueChanged.AddListener(delegate {RosValueChangeInputField(); });
        slider.onValueChanged.AddListener(delegate {RosValueChangeSlider(); });
    }

    // public void RosValueChangeInputField()
    // {
    //     intResultTryParse = int.TryParse(inputField.text, out value);
    //     if (intResultTryParse == true) {
    //         ValueMsg currentValue = new ValueMsg(value);
    //         ros.Publish(topicName, currentValue);
    //     }
    // }
    public void RosValueChangeSlider()
    {
            value = (int) slider.value;
            ValueMsg currentValue = new ValueMsg(value);
            ros.Publish(topicName, currentValue);
    }

    // public void RosClearValue()
    // {
    //     ValueMsg currentValue = new ValueMsg(0);
    //     ros.Publish(topicName, currentValue);
    // }

    void Update()
    {

    }
}