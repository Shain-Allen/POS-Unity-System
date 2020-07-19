using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEntryController : MonoBehaviour
{
    public string itemCode;
    public TMP_InputField inputField;

    public void StoreItemCode()
    {
        itemCode = inputField.text;
        Debug.Log(itemCode);
    }

    public void NumberPadNumber(int number)
    {
        inputField.text += number.ToString();
    }
}
