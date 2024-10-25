using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DelayedButton : MonoBehaviour
{
    public Button myButton;  // Reference to the button
    private bool isReady = false;

    void Start()
    {
        // Hide the button initially
        myButton.gameObject.SetActive(false);

        // Start the coroutine to make the button appear after a delay
        StartCoroutine(ShowButtonAfterDelay(3f));
    }

    IEnumerator ShowButtonAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Show the button
        myButton.gameObject.SetActive(true);
        isReady = true;
    }

    public void LoadLevel()
    {
        if (isReady)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
