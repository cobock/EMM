using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript2 : MonoBehaviour
{
    public GameObject Menu;
    public GameObject ReturnButton;
    public GameObject RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Menu.SetActive(!Menu.activeSelf);
        }

        if (Menu.activeSelf)
        {
            Time.timeScale = 0;
        }
    }

    public void restartGame()
    {
        Debug.Log("restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void returnToGame()
    {
        Debug.Log("return");
        Menu.SetActive(false);
    }
}
