using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float delayTimer = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false; // Flag to check if the player has already crashed
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true; // Set the flag to true to prevent multiple crashes
            Object.FindFirstObjectByType<PlayerController>().DisableControls(); // Disable player controls
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayTimer);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
