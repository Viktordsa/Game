using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName; 

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player")) 
        {
            SceneManager.LoadScene(SceneName); 
        }
    }
}