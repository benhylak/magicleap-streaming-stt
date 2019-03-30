using UnityEngine;
using System.Collections;
using UnityEditor;

#if UNITY_EDITOR
[CustomEditor(typeof(StreamingDemoManager))]
public class DemoManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        StreamingDemoManager demoManager = (StreamingDemoManager)target;
        if(GUILayout.Button("Start Speech Recog"))
        {
            demoManager.StartSpeechRecognition();
        }
    }
}
#endif
