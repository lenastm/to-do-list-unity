using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class ItemsManager : MonoBehaviour
{

    public GameObject itemPrefab;
    public Transform itemParent;
    public Button createBtn;
    public static ItemsManager instance;
    public TextMeshProUGUI compteur;

    public List<Item> itemsCompleted = new List<Item>();
    public List<Item> itemsIncomplete = new List<Item>();

    private int completed = 1;
    private int incomplete = 0;
    

    private void Awake()
    {
        instance = this;
    }

    public void CreateNewItem()
    {
        CreateItem(" ", 0);

        completed = itemsCompleted.Count;
        incomplete = itemsIncomplete.Count;
        OnValidate();
    }

    public void CreateItem(string itemDescription, int index)
    {
        GameObject newItem = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab, itemParent);
        Item newItemComponent = newItem.GetComponent<Item>();
        newItemComponent.SetItem(itemDescription, index);
        itemsIncomplete.Add(newItemComponent);
        //newItemComponent.GetComponent<Toggle>().onValueChanged.AddListener(delegate { checkItem(newItemComponent); });
    }

    public void CheckItem(Item item, bool isChecked)
    {
        
        if (isChecked)
        {
            itemsIncomplete.Remove(item);
            itemsCompleted.Add(item);

            completed = itemsCompleted.Count;
            incomplete = itemsIncomplete.Count;

            OnValidate();

        }
        else
        {
            itemsCompleted.Remove(item);
            itemsIncomplete.Add(item);

            completed = itemsCompleted.Count;
            incomplete = itemsIncomplete.Count;

            OnValidate();

        }
    }

    private void OnValidate()
    {
        compteur.text = incomplete.ToString() + " incomplete, " + completed.ToString() + " completed";
    }

    public void Supprime(Item item)
    {
        if (itemsCompleted.Contains(item) == true)
        {
            itemsCompleted.Remove(item);
            completed = itemsCompleted.Count;
            incomplete = itemsIncomplete.Count;
            OnValidate();
        }
        else 
        {
            itemsIncomplete.Remove(item);
            completed = itemsCompleted.Count;
            incomplete = itemsIncomplete.Count;
            OnValidate();
        }
    }
}
