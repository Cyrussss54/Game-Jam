using UnityEngine;

public class RevealZone : MonoBehaviour
{
    public Transform ballTransform;
    public float revealDistance = 5f;

    private Material mat;
    private Color zoneColor;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        zoneColor = mat.color;
    }

    void Update()
    {
        if (ballTransform == null) return;

        float distance = Vector3.Distance(transform.position, ballTransform.position);
        float alpha = 1.0f - Mathf.Clamp01(distance / revealDistance);

        zoneColor.a = alpha;
        mat.color = zoneColor;
    }
}
