using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    [Header("InventoryObjects")]
    public GameObject[] item;

    public bool[] inventory;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < item.Length; i++)
        {
            inventory[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {       
        if (item[1].activeSelf)
        {
            inventory[1] = true;
        }               
    }
}
