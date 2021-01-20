using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour { 

    public TextMeshProUGUI itemText;
    public Toggle toggle;
    public int index;

    public void SetItem(string itemDescription, int index){

            itemText.text = itemDescription;
            this.index = index;
    }

    public void CheckItem(bool isChecked)
    {
        if (isChecked)
        {
            // barrer le texte
            itemText.fontStyle = FontStyles.Strikethrough;

        } else {
            // enlever barrer
            itemText.fontStyle = FontStyles.Normal;
        }
        ItemsManager.instance.CheckItem(this, isChecked);
    }

    private void Start()
    {
        string itemDescription = PlayerPrefs.GetString("itemDescription");
        itemText.text = itemDescription;
    }


    public void SaveName(string itemDescription)
    {
        PlayerPrefs.SetString("itemDescription", itemDescription);
    }

    public void supp()
    {
        if (true == gameObject.activeInHierarchy) //Si l'objet est actif
        {
            gameObject.SetActive(false);	//alors on le désactive
        }
    }

}
