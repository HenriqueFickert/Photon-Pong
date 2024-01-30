using UnityEngine;
using UnityEngine.UI;

public class ColorMenu : MonoBehaviour
{
    public Color choosedColor;
    public Image colorImage;
    public PlayerInformations playerInformations;


    public void ApplyNewColor(Color newColor)
    {
        choosedColor = newColor;
        colorImage.color = choosedColor;

        if (playerInformations == null)
            return;

        playerInformations.OnPlayerColorUpdate(choosedColor);
    }
}
