using UnityEngine;

public class TriggerZoneWall : MonoBehaviour
{
    [Tooltip("Drag the 'Disappearing Wall' GameObject here in the Inspector.")]
    public GameObject disappearingWall;

    [Tooltip("The exact name of the object that triggers the zone.")]
    public string triggeringObjectName = "Ball";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the zone is named "Ball"
        if (other.gameObject.name == triggeringObjectName)
        {
            if (disappearingWall != null)
            {
                // Deactivate the wall so it disappears
                disappearingWall.SetActive(false);

                // Optional: Disable the trigger zone itself so it only happens once
                gameObject.SetActive(false);
            }
            else
            {
                Debug.LogWarning("Disappearing Wall reference is missing in the Inspector!");
            }
        }
    }
}