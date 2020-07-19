using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_manager : MonoBehaviour
{
    public GameObject itemContainer;
    public GameObject itemBlank;
    public GameObject ItemEntryPopUp;
    public List<ItemBlank> inventory;

    public void ItemEntry()
    {
        if(inventory.Count == 0)
        {
            Instantiate<GameObject>(itemBlank).transform.SetParent(itemContainer.transform, false);
        }
        else
        {
            ItemEntryPopUp.SetActive(true);
        }
    }
}
