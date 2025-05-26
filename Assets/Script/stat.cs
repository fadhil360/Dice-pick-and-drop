using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class stat : MonoBehaviour
{
    public int number = 0;
    public GameObject[] dices;
    private bool show = false;
    TextMeshProUGUI textMeshProUGUI;
    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();  
        textMeshProUGUI.text = ("Dice Total : 0");
    }
    private void Update()
    {
        show = true;
        foreach (var d in dices)
        {
            if (d != null)
            {
                if (d.GetComponent<DiceTotal>().send == false)
                {
                    show = false;
                }
            }
        }
        if (show)
        {
            textMeshProUGUI.text = ("Dice Total : "+number);
        }
    }
}
