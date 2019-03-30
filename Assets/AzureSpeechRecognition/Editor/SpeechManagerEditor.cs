using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpeechManager))]
public class SpeechManagerEditor : Editor 
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        SpeechManager speechManager = (SpeechManager) target;  
        
        if(GUILayout.Button("Start Listening"))
        {
            speechManager.StartSpeechRecognitionFromMicrophone();
        }
    }
}