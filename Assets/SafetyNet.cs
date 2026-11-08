using UnityEngine;

public class SafetyNet : MonoBehaviour
{
    private Transform spawnTransform;

    void Start()
    {
        GameObject spawnObject = GameObject.Find("SpawnPoint");
        if (spawnObject != null)
        {
            spawnTransform = spawnObject.transform;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            if (spawnTransform != null)
            {
                Rigidbody rb = other.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.linearVelocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }

                other.transform.position = spawnTransform.position;
            }
        }
    }
}
