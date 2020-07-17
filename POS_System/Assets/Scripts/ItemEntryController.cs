using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEntryController : MonoBehaviour
{
    public string itemCode;
    public GameObject inputField;

    public void StoreItemCode()
    {
        itemCode = inputField.GetComponent<TextMeshProUGUI>().text;
        Debug.Log(itemCode);
    }

    public void NumberPadNumber(int number)
    {
        inputField.GetComponent<TextMeshProUGUI>().text += number.ToString();
    }
}
