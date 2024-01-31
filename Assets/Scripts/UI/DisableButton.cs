using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    public void DisableButtonByInputField(TMP_InputField inputField)
    {
        if (inputField == null || button == null) return;

        if (inputField.text.Length <= 4)
            button.interactable = false;
        else
            button.interactable = true;
    }
}
