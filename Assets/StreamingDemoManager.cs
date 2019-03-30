using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class StreamingDemoManager : MonoBehaviour
{
    public SpeechManager SpeechManager;
    
    // Start is called before the first frame update
    void Start()
    {
        MLInput.OnTriggerDown += (id, value) =>
        {
            StartSpeechRecognition();
        };
    }

    public void StartSpeechRecognition()
    {
        SpeechManager.StartSpeechRecognitionFromMicrophone();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
