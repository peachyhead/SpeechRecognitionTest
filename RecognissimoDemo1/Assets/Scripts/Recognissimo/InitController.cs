using Recognissimo.Components;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

public class InitController : MonoBehaviour
{
    [SerializeField] private VoiceControl _voiceControl;
    [SerializeField] private TMP_Text _infoText;
    [SerializeField] private Image _imageToggle;
    [SerializeField] private TMP_Text _outputText;
    [SerializeField] private ActivateProcessing _activateProcessing;

    private bool _isInit;

    public void OnStartButton()
    {
        if (_isInit)
        {
            return;
        }

        _voiceControl = Instantiate(_voiceControl);
        _voiceControl.GetComponent<VoiceTriggerHandler>().ImageToggle = _imageToggle;
        _voiceControl.GetComponentInChildren<RecognitionLogger>().OutputText = _outputText;
        _activateProcessing.VoiceControl = _voiceControl;

        var metricMic = Stats.Create("Mic_init");
        metricMic.Start();
        _voiceControl.GetComponentInChildren<MicrophoneSpeechSource>().StartMicrophone();
        metricMic.Stop();
        var metricModel = Stats.Create("LangModel_init");
        metricModel.Start();
        _voiceControl.GetComponentInChildren<LanguageModelProvider>().Setup();
        metricModel.Stop();

        var metricVoice = Stats.Create("VoiceRec_init");
        metricVoice.Start();
        _voiceControl.Setup();
        _voiceControl.StartControl();
        metricVoice.Stop();

        _isInit = true;
        _infoText.text = "Say start or stop";
    }
}
