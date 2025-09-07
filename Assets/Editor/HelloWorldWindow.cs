using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // always rrequired for editor scripting

//Key classes:
//EditorWindow : create custom windows
//Editor : create custom inspectors 
// Menu Item : Add menu entries 
//EditorGUILayout : UI Controls inside editor windows 
// 

public class HelloWorldWindow : EditorWindow
{

    private string message = "Type here...";
    private int number = 0;

    [MenuItem("Tools/Hello World")]
    public static void ShowWindow()
    {
        GetWindow<HelloWorldWindow>("Hello World");
    }

    private void OnGUI()
    {
        GUILayout.Label("Editor Tool Label", EditorStyles.boldLabel);

        if (GUILayout.Button("Click me"))
        {
            Debug.Log("Hello world message");
        }

        message  = EditorGUILayout.TextField("Message:", message);


        if (GUILayout.Button("Print message"))
        {
            Debug.Log("User Typed: "+message + number);

        }

        number= EditorGUILayout.IntField("Enter Number:", number);

        GUILayout.Label("Simple label", EditorStyles.boldLabel);
        string name = EditorGUILayout.TextField("Name", "Default");
        bool toggle = EditorGUILayout.Toggle("Enable feature", true);
        if(GUILayout.Button("Do something"))
        {
            Debug.Log("Button clicked");
        }

    }
}
