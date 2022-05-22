using Recognissimo.Components;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivateProcessing : MonoBehaviour
{
    [SerializeField] private TMP_Text _activateProccessText;
    public VoiceControl VoiceControl { get; set; }

    private bool toogleProcces = true;
    private string[] activateText = { "On", "Off" };

    private void Start()
    {
        _activateProccessText.text = toogleProcces ? activateText[0] : activateText[1];
    }

    public void OnClickHandler()
    {
        if (!VoiceControl)
            return;

        toogleProcces = !toogleProcces;
        if(toogleProcces)
        {
            VoiceControl.Setup();
            VoiceControl.StartControl();
            _activateProccessText.text = activateText[0];
        }
        else
        {
            VoiceControl.StopControl();
            _activateProccessText.text = activateText[1];
        }

    }
}
