using UnityEngine;

public class ObstacleDestroyed : MonoBehaviour
{
    public GameObject replacementPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Instantiate(replacementPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
