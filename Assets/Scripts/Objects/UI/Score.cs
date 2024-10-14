using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;

    public static int score = 0;

    private void Start()
    {
        scoreTxt.text = score.ToString();
    }

    public void AddScore(int _addScore)
    {
        score += _addScore;
        scoreTxt.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
