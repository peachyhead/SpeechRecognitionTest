using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public void On10FPSClick()
    {
        Application.targetFrameRate = 10;
    }

    public void On30FPSClick()
    {
        Application.targetFrameRate = 30;
    }

    public void On60FPSClick()
    {
        Application.targetFrameRate = 60;
    }
}
