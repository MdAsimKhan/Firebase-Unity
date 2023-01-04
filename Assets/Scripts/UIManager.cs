using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    private GameObject loginPanel;

    [SerializeField]
    private GameObject registrationPanel;

    [SerializeField]
    private GameObject forgotPasswordPanel;

    [SerializeField]
    private GameObject scoreboardPanel;

    [SerializeField]
    private GameObject userdataPanel;

    private void Awake()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void OpenLoginPanel()
    {
        loginPanel.SetActive(true);
        registrationPanel.SetActive(false);
        forgotPasswordPanel.SetActive(false);
        userdataPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
    }

    public void OpenRegistrationPanel()
    {
        registrationPanel.SetActive(true);
        forgotPasswordPanel.SetActive(false);
        loginPanel.SetActive(false);
        userdataPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
    }

    public void OpenForgotPasswordPanel()
    {
        forgotPasswordPanel.SetActive(true);
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        userdataPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
    }

    public void GoBackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FirebaseAuth");
    }

    public void OpenScoreboardScreen()
    {
        forgotPasswordPanel.SetActive(false);
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        userdataPanel.SetActive(false);
        scoreboardPanel.SetActive(true);
    }

    public void OpenUserdataScreen()
    {
        forgotPasswordPanel.SetActive(false);
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        userdataPanel.SetActive(true);
        scoreboardPanel.SetActive(false);
    }
}