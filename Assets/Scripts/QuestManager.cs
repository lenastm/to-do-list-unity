using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject questPrefab;
    public Transform questParent;

    public void CreateQuest(string questDescription, Sprite questSprite)
    {
        GameObject newQuest = (GameObject)PrefabUtility.InstantiatePrefab(questPrefab, questParent);
        Quest newQuestComponent = newQuest.GetComponent<Quest>();
        newQuestComponent.SetQuest(questSprite, questDescription);
    }
}
