using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour { 

    // public Image isChecked;
    public TextMeshProUGUI itemText;
    public int index;

public void SetItem(string itemDescription, int index){
/*    isChecked.sprite = itemSprite;*/
        itemText.text = itemDescription;
        this.index = index;
}

  
}
