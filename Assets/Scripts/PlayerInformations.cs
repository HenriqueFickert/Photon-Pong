using Fusion;
using TMPro;
using UnityEngine;

public class PlayerInformations : MonoBehaviour
{

    //[Networked] public string PlayerName { get => playerName; }
    //[Networked] public Color PlayerColor { get => playerColor; }

    public string playerName ;
    public Color playerColor;

    public void OnPlayerNameUpdate(TMP_InputField playerNameInput)
    {
        playerName = playerNameInput.text;
    }

    public void OnPlayerColorUpdate(Color color)
    {
        playerColor = color;
    }
}
