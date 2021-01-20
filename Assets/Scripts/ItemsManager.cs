using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ItemsManager : MonoBehaviour
{

    public GameObject itemPrefab;
    public Transform itemParent;
    public Button createBtn;
    public int index = 3;

    private List<Item> items = new List<Item>();




    public void CreateNewItem()
    {

        CreateItem(" ", 4);
        
    }

    public void CreateItem(string itemDescription, int index)
    {
        GameObject newItem = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab, itemParent);
        Item newItemComponent = newItem.GetComponent<Item>();
        newItemComponent.SetItem(itemDescription, index);
        items.Add(newItemComponent);
        newItemComponent.GetComponent<Toggle>().onValueChanged.AddListener(delegate { checkItem(newItemComponent); });
    }


    void checkItem(Item item)
    {
        Debug.Log("item checked");
    }
}
