using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Color color;
    public string colorName;

    public Button button;
    public TextMeshProUGUI text;

    private ColorMenu menu;

    private void Awake()
    {
        button = GetComponent<Button>();
        text = GetComponentInChildren<TextMeshProUGUI>();
        menu = GetComponentInParent<ColorMenu>();
    }

    private void Start()
    {
        button.image.color = color;
        text.SetText(colorName);
        button.onClick.AddListener(ApplyColor);
    }


    private void ApplyColor()
    {
        menu.ApplyNewColor(color);
    }
}
