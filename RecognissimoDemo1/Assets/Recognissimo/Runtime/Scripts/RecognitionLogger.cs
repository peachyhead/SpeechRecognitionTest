using Recognissimo.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecognitionLogger : MonoBehaviour
{
    public TMP_Text OutputText { get; set; }

    public void OnResult(Result result)
    {
        OutputText.text = result.text;
    }
}
