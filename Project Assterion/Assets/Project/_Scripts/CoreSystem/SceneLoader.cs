using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string test;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) SceneManager.LoadScene(test);
    }
}