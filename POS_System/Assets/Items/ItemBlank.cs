using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
public class ItemBlank : ScriptableObject
{
    public string item_name;
    public ulong upc;
    public ulong sku;
    public float price;
    public int quanity;
}
