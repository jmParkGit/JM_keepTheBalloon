using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public static gameManager I;
    public GameObject rain;
    public GameObject panel;
    public Text timeText;

    float t = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
        initGame();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        timeText.text = t.ToString("N2");
    }

    void Awake()
    {
        I = this;
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        t = 0.0f;
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    
    public void collide()
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
