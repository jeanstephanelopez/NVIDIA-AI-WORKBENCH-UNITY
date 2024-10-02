using UnityEngine;
using TMPro;

public class EnterKeySimulator : MonoBehaviour
{
    public TextMeshProUGUI chatDisplayText;
    private string lastText = "";

    void Update()
    {
        // Check if new text has been added
        if (chatDisplayText.text != lastText)
        {
            lastText = chatDisplayText.text;
            SimulateEnter();
        }
    }

    private void SimulateEnter()
    {
        if (chatDisplayText.text != lastText) // Prevent unnecessary UI refreshes
        {
            chatDisplayText.ForceMeshUpdate();
            chatDisplayText.SetAllDirty();
            Canvas.ForceUpdateCanvases();
        }
    }
}