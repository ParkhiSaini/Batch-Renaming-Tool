using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BatchRenameTool : EditorWindow
{
    private string baseName = "GameObject";
    private int  startNumber= 1;

    [MenuItem("Tools/BatchRenameTool")]

    public static void ShowWindow()
    {
        GetWindow<BatchRenameTool>("Batch Rename Tool");
    }

    public void OnGUI()
    {
        GUILayout.Label("Batch Rename Tool", EditorStyles.boldLabel);

        baseName = EditorGUILayout.TextField("Base Name", baseName);
        startNumber = EditorGUILayout.IntField("Start number", startNumber);

        if(GUILayout.Button("Rename Selected"))
        {
            RenamSelectedObjects();
        }

    }

    private void RenamSelectedObjects()
    {
        Object[] selectedObjects = Selection.objects; // Selecction.objects all currently selected items in the hierarchy/Project

        int counter = startNumber;
        foreach (Object obj in selectedObjects)
        {
            if(obj is GameObject go)
            {
                Undo.RecordObject(go,"Batch Rename");
                go.name = baseName + " " + counter;
                counter++;
            }
        }
        Debug.Log("Renaming objects");
    }
        


}
