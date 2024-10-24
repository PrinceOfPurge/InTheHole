using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour
{
    public Button resumeButton;
    public Button mainMenuButton;
    public Image pauseMenuHolder;

    // Start is called before the first frame update
    void Start()
    {
        resumeButton.onClick.AddListener(OnResumeButtonClick);
        mainMenuButton.onClick.AddListener(OnMainMenuButtonClick);
    }

    void OnResumeButtonClick()
    {
        pauseMenuHolder.gameObject.SetActive(false);
        Debug.Log("get rid of pause menu");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuHolder.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
