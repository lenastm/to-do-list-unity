using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Item))]
public class EditItem : Editor
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnSceneGUI()
    {
        Item item = (Item)target;

        Handles.BeginGUI();
        string showedName = item.itemText.text;
        if (showedName.Trim() == "")
        {
            GUILayout.Label("Item is empty");
        }
        else
        {
            GUILayout.Label("item name is : " + showedName);
        }

        if (GUILayout.Button("Debug item Name", GUILayout.Width(150)))
        {
            Debug.Log(showedName);
        }

        Handles.EndGUI();
    }


}

