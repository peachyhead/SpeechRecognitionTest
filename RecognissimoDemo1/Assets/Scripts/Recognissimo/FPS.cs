using System.Collections;
using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        StartCoroutine(IntervalShow());
    }

    IEnumerator IntervalShow()
    {
        while (true)
        {
            _text.text ="FPS: " + ((int)(1 / Time.unscaledDeltaTime)).ToString();
            yield return new WaitForSeconds(0.2f);
        }
    }
}
