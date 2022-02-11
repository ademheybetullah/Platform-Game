using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisonControls : MonoBehaviour
{
    public string nextLevel;
    public string levelStar;
    public int score;
    int coins;
    public Text scoreText, finishText;
    public Button btnNext, btnPrevious, btnRepeat,btnExit,btnRight,btnLeft,btnJump;
    Animator chestAnm;
    public GameObject chest;
    character player;
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("coin").Length;
        score = 0;
        chestAnm = chest.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "chest")
        {
            Tebrikler();
        }
        else if (collision.gameObject.tag == "enemy")
        {
            TekrarDeneyini();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score + "";
        }
    }
    public void TekrarDeneyini()
    {
        
        finishText.text = "Tekrar Deneyiniz";
        btnJump.gameObject.SetActive(false);
        btnLeft.gameObject.SetActive(false);
        btnRight.gameObject.SetActive(false);
        btnPrevious.gameObject.SetActive(true);
        btnRepeat.gameObject.SetActive(true);
        finishText.gameObject.SetActive(true);
        btnExit.gameObject.SetActive(true);
    }
    public void Tebrikler()
    {
        if (PlayerPrefs.GetInt(levelStar) < score)
        {
            if (score <= 4)
            {
                PlayerPrefs.SetInt(levelStar, 1);
            }
            else if (score <= coins-5 && score > 4)
            {
                PlayerPrefs.SetInt(levelStar, 2);
            }
            else if (score > coins-2)
            {
                PlayerPrefs.SetInt(levelStar, 3);
            }
        }
        PlayerPrefs.SetInt(nextLevel, 1);
        chestAnm.enabled = true;
        finishText.text = "Tebrikler";
        btnJump.gameObject.SetActive(false);
        btnLeft.gameObject.SetActive(false);
        btnRight.gameObject.SetActive(false);
        btnNext.gameObject.SetActive(true);
        btnPrevious.gameObject.SetActive(true);
        btnRepeat.gameObject.SetActive(true);
        finishText.gameObject.SetActive(true);
        btnExit.gameObject.SetActive(true);
    }
}
