using TMPro;
using UnityEngine;

public class InspectionUIManager : MonoBehaviour
{
    [SerializeField] private GameObject inspectionPanel;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text descriptionText;

    private void Start()
    {
        HidePanel();
    }

    public void ShowPanel(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
        inspectionPanel.SetActive(true);
    }

    public void HidePanel()
    {
        inspectionPanel.SetActive(false);
    }
}