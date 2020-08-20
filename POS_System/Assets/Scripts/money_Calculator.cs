using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class money_Calculator : MonoBehaviour
{
    public GameObject items;

    public TextMeshProUGUI savings;
    public TextMeshProUGUI subtotal;
    public TextMeshProUGUI tax;
    public TextMeshProUGUI balanceDue;

    public double TaxAmount = 0.1;

    double savingsAmount;
    double subtotalAmount;

    enum ItemContents
    {
        heck
    };

    // Update is called once per frame
    void Update()
    {
        subtotalAmount = 0;
        if(items.transform.childCount >= 0)
        {
            for (int i = 0; i < items.transform.childCount; i++)
            {
                subtotalAmount += Convert.ToDouble(items.transform.GetChild(i).transform.GetChild(1).GetComponent<TextMeshProUGUI>().text);
            }

            subtotal.text = "$" + subtotalAmount.ToString();
            tax.text = "$" + (subtotalAmount * TaxAmount).ToString();
            balanceDue.text = "$" + (subtotalAmount * (1 + TaxAmount)).ToString();
        }
    }
}
