using System.Collections;
using UnityEngine;

public class FadeOutOnTouch : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("The tag used to identify the player GameObject.")]
    public string playerTag = "Player";

    [Tooltip("The name of the player GameObject as a fallback.")]
    public string playerName = "Ball";

    [Tooltip("How many seconds it takes for the wall to fade out completely.")]
    public float fadeDuration = 1.0f;

    private Renderer wallRenderer;
    private bool isFading = false;

    void Start()
    {
        wallRenderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Triggers if either the tag matches "Player" OR the GameObject name matches "Ball"
        if (!isFading && (other.CompareTag(playerTag) || other.gameObject.name == playerName))
        {
            StartCoroutine(FadeOutRoutine());
        }
    }

    IEnumerator FadeOutRoutine()
    {
        isFading = true;

        if (wallRenderer == null)
        {
            gameObject.SetActive(false);
            yield break;
        }

        Material mat = wallRenderer.material;
        Color startColor = mat.color;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startColor.a, 0f, elapsedTime / fadeDuration);

            Color newColor = new Color(startColor.r, startColor.g, startColor.b, alpha);
            mat.color = newColor;

            yield return null;
        }

        mat.color = new Color(startColor.r, startColor.g, startColor.b, 0f);
        gameObject.SetActive(false);
    }
}