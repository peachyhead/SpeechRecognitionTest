using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceTriggerHandler : MonoBehaviour
{
    public Image ImageToggle { get; set; }

    public void OnStopTrigger()
    {
        ImageToggle.gameObject.SetActive(false);
    }

    public void OnStartTrigger()
    {
        ImageToggle.gameObject.SetActive(true);
    }
}
