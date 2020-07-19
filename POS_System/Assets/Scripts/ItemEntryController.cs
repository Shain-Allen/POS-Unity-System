using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEntryController : MonoBehaviour
{
    public TMP_InputField inputField;

    public void NumberPadNumber(string number)
    {
        inputField.text += number;
    }

    public void NumberPadClear()
    {
        inputField.text = "";
    }

    public void NumberPadBackButton()
    {
        inputField.text = inputField.text.Remove(inputField.text.Length - 1);
    }
}
