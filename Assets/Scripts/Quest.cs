using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest : MonoBehaviour
{
    public Image questImage;
    public TextMeshProUGUI questText;

    public void SetQuest(Sprite questSprite, string questDescription)
    {
        questImage.sprite = questSprite;
        questText.text = questDescription;
    }
}
