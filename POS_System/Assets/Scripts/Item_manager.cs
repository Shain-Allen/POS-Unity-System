using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_manager : MonoBehaviour
{
    public GameObject itemContainer;
    public GameObject itemBlank;
    public TMP_InputField ItemEntryField;
    public List<ItemBlank> inventory;

    string ItemLookUpCode;

    public void ItemEntry()
    {
        if(inventory.Count == 0 || ItemEntryField.text == "")
        {
            GameObject newItem = Instantiate(itemBlank, itemContainer.transform, false);
        }
        else
        {
            ItemLookUpCode = ItemEntryField.text;

            if (ItemLookUpCode.Length == 8)
            {
                GameObject newItem;
                ItemBlank itemInfo = FindBySKU(Convert.ToUInt64(ItemLookUpCode));
                if (itemInfo == null)
                {
                    newItem = Instantiate(itemBlank, itemContainer.transform, false);

                }
                else
                {
                    newItem = Instantiate(itemBlank, itemContainer.transform, false);
                    //Debug.Log(itemInfo.name);
                    //Debug.Log(newItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
                    newItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemInfo.name;
                    newItem.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "$" + itemInfo.price.ToString();
                    newItem.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = itemInfo.upc.ToString();
                }
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
