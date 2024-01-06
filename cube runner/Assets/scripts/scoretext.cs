using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class scoretext : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalscoretext;

    int myscore = 0;

    void Update()
    {
        scoreText.text = myscore.ToString();
        finalscoretext.text = "Score: " + myscore.ToString();
    }
    public void addscore(int score)
    {
        
        myscore = myscore +score;

    }
}
/*using UnityEngine;
using TMPro;

public class scoretext : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI finalScoreText;

    private int myscore = 0;

    public int myscore
    {
        get => myscore;
        private set
        {
            myscore = value;
            UpdateScoreText();
        }
    }

    private void Start()
    {
        // Ensure the TextMeshProUGUI components are assigned in the Unity editor or through code.
        if (scoretext == null || finalscoretext == null)
        {
            Debug.LogError("Please assign scoreText and finalScoreText in the inspector.");
        }

        UpdateScoreText();
    }

    public void AddScore(int score)
    {
        myscore += score;
    }

    private void UpdateScoreText()
    {
        scoreText.text = myscore.ToString();
        finalscoretext.text = "Score: " + myscore.ToString();
    }
}*/

