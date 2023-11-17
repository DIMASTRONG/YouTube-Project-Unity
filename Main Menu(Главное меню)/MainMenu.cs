using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string scene;
    public TMP_Dropdown dropdown;
    public GameObject SettingsMenu;

    void Start()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(QualitySettings.names.ToList());
        dropdown.value = QualitySettings.GetQualityLevel();
    }

    public void Play()
    {
        SceneManager.LoadScene(scene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void QualityChoose()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
    }

    public void SettingsOpen()
    {
        SettingsMenu.SetActive(true);
    }

    public void SettingsClose()
    {
        SettingsMenu.SetActive(false);
    }
}
