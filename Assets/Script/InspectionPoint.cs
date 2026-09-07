using System.Collections;
using UnityEngine;

public class InspectionPoint : MonoBehaviour
{
    [SerializeField] private string inspectionTitle;

    [TextArea(3, 6)]
    [SerializeField] private string inspectionDescription;

    [SerializeField] private InspectionUIManager uiManager;

    [Header("Click Animation")]
    [SerializeField] private float clickScale = 1.35f;
    [SerializeField] private float animationDuration = 0.15f;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        if (uiManager != null)
        {
            uiManager.ShowPanel(
                inspectionTitle,
                inspectionDescription
            );
        }
        else
        {
            Debug.LogWarning("UI Manager não configurado.");
        }

        StopAllCoroutines();
        StartCoroutine(AnimateClick());
    }

    private IEnumerator AnimateClick()
    {
        Vector3 enlargedScale = originalScale * clickScale;
        float halfDuration = animationDuration / 2f;
        float elapsedTime = 0f;

        while (elapsedTime < halfDuration)
        {
            elapsedTime += Time.deltaTime;

            transform.localScale = Vector3.Lerp(
                originalScale,
                enlargedScale,
                elapsedTime / halfDuration
            );

            yield return null;
        }

        elapsedTime = 0f;

        while (elapsedTime < halfDuration)
        {
            elapsedTime += Time.deltaTime;

            transform.localScale = Vector3.Lerp(
                enlargedScale,
                originalScale,
                elapsedTime / halfDuration
            );

            yield return null;
        }

        transform.localScale = originalScale;
    }
}