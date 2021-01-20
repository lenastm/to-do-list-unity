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
    public static ItemsManager instance;

    public List<Item> itemsCompleted = new List<Item>();
    public List<Item> itemsIncompleted = new List<Item>();


    private void Awake()
    {
        instance = this;
    }

    public void CreateNewItem()
    {

        CreateItem(" ", 4);
        
    }

    public void CreateItem(string itemDescription, int index)
    {
        GameObject newItem = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab, itemParent);
        Item newItemComponent = newItem.GetComponent<Item>();
        newItemComponent.SetItem(itemDescription, index);
        itemsIncompleted.Add(newItemComponent);
        //newItemComponent.GetComponent<Toggle>().onValueChanged.AddListener(delegate { checkItem(newItemComponent); });
    }


    public void CheckItem(Item item, bool isChecked)
    {
        
        if (isChecked)
        {
            itemsIncompleted.Remove(item);
            itemsCompleted.Add(item);

            Debug.Log("item checked");

        }
        else
        {
            itemsCompleted.Remove(item);
            itemsIncompleted.Add(item);

            Debug.Log("item unchecked");
        }
    }
}
