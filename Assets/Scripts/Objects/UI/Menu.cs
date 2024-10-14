using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource musicBG;
    [SerializeField] private AudioClip myClip;

    private void Awake()
    {
        musicBG = GetComponent<AudioSource>();
    }

    public void LoadGame()
    {
        musicBG.PlayOneShot(myClip);
        StartCoroutine(TimeLoadScene());
    }

    public void LoadExit()
    {
        musicBG.PlayOneShot(myClip);
        Application.Quit();
    }

    public void LoadMenu()
    {
        musicBG.PlayOneShot(myClip);
        StartCoroutine(TimeLoadScene());
        SceneManager.LoadScene("MainMenu");
        Score.score = 0;
    }

    IEnumerator TimeLoadScene()
    {
        yield return new WaitForSeconds(0.18f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
