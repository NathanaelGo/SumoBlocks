using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Rigidbody redrb;
    public Rigidbody bluerb;
    public Transform red;
    public Transform blue;
    public Text winTextR;
    public Text winTextB;
    public Color redColor;
    public Color redColorAlfa;
    public Color blueColor;
    public Color blueColorAlfa;
    public GameObject setting;
    public GameObject winCanvas;
    private bool isShowing;
    private bool hasWon = false;


    // Update is called once per frame
    void Update ()
    {
		if(red.position.y < 0 && !hasWon)
        {
            hasWon = true;
            winTextB.color = blueColor;
        }
        if (red.position.y < -200)
        {
            hasWon = false;
            winTextB.color = blueColorAlfa;
            red.position = new Vector3(7.0f, 1.5f, -7.0f);
            blue.position = new Vector3(-7.0f, 1.5f, 7.0f);
            redrb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            bluerb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (blue.position.y < 0 && !hasWon)
        {
            hasWon = true;
            winTextR.color = redColor;
        }
        if (blue.position.y < -200)
        {
            hasWon = false;
            winTextR.color = redColorAlfa;
            red.position = new Vector3(7.0f, 1.5f, -7.0f);
            blue.position = new Vector3(-7.0f, 1.5f, 7.0f);
            redrb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            bluerb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            isShowing = !isShowing;
            setting.SetActive(isShowing);
            winCanvas.SetActive(!isShowing);
            winTextB.color = blueColorAlfa;
            winTextR.color = redColorAlfa;
        }
    }

    //Scene Manager
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ToCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
