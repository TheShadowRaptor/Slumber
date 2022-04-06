using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchQuest : MonoBehaviour
{
    [Header("Scripts")]
    public Inventory inventory;
    public interactionObject interactionObject;

    [Header("QuestItemNumber")]
    public int QuestItemNumber;

    [Header("ToggleGameObjects")]
    public GameObject[] _gameObject;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.inventory[QuestItemNumber] == true)
        {
            interactionObject.ToggleObjectsActive();
        }
    }
}
