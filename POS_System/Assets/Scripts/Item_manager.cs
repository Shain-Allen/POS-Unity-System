using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item_manager : MonoBehaviour
{
    public GameObject itemContainer;
    public GameObject itemBlank;
    public TMP_InputField ItemEntryField;
    public List<ItemBlank> inventory;

    string ItemLookUpCode;

    public void ItemEntry()
    {
        if(inventory.Count == 0)
        {
            GameObject newItem = Instantiate(itemBlank);
            newItem.transform.SetParent(itemContainer.transform);
        }
        else
        {
            ItemLookUpCode = ItemEntryField.text;

            if (ItemLookUpCode.Length == 8)
            {
                FindBySKU(Convert.ToUInt64(ItemLookUpCode));
                GameObject newItem = Instantiate(itemBlank);
                newItem.transform.SetParent(itemContainer.transform);
            }
        }
    }

    ItemBlank FindByUPC(ulong UPC)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if(inventory[i].upc == UPC)
            {
                return inventory[i];
            }
        }

        return null;
    }

    ItemBlank FindBySKU(ulong SKU)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].sku == SKU)
            {
                return inventory[i];
            }
        }

        return null;
    }
}
