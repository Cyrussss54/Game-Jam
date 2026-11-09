using UnityEngine;

public class AppearOnTrigger : MonoBehaviour
{
    [Header("Hint")]
    [Tooltip("Drag the object here that you want to appear when entering the trigger.")]
    public GameObject objectToAppear;

    [Header("Player Settings")]
    public string playerTag = "Player";
    public string playerName = "Ball";

    [Header("Settings")]
    [Tooltip("If checked, the object will disappear again when leaving the trigger zone.")]
    public bool disappearOnExit = false;

    void Start()
    {
        // Ensure the object starts hidden (optional, un-comment if needed)
        /*
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(false);
        }
        */
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger
        if (other.CompareTag(playerTag) || other.gameObject.name == playerName)
        {
            if (objectToAppear != null)
            {
                objectToAppear.SetActive(true);
            }
            else
            {
                Debug.LogWarning("AppearOnTrigger: No object assigned to appear!", this);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Optionally hide the object again when the player leaves the zone
        if (disappearOnExit && (other.CompareTag(playerTag) || other.gameObject.name == playerName))
        {
            if (objectToAppear != null)
            {
                objectToAppear.SetActive(false);
            }
        }
    }
}