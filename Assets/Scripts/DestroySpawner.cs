using UnityEngine;

public class DestroySpawner : MonoBehaviour
{
    public GameObject Spawner;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(Spawner);
        }
    }
}