using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour { 

    public TextMeshProUGUI itemText;
    public Toggle toggle;
    public int index;

    Color color1;
    

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
            ColorUtility.TryParseHtmlString("#8c8c8c", out color1);
            itemText.color = color1;

        } else {
            // enlever barrer
            itemText.fontStyle = FontStyles.Normal;
            ColorUtility.TryParseHtmlString("#ffffff", out color1);
            itemText.color = color1;

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

    public void Supp()
    {
        if (true == gameObject.activeInHierarchy) //Si l'objet est actif
        {
            gameObject.SetActive(false);	//alors on le désactive
        }
        ItemsManager.instance.Supprime(this);
    }

}
