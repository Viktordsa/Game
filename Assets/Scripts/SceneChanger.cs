using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName; 

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player") | other.collider.CompareTag("Sword")) 
        {
            SceneManager.LoadScene(SceneName); 
        }
    }
}