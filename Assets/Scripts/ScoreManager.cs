using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ScoreManager
{
    static ScoreManager _instance = new ScoreManager();
    public static ScoreManager Instance => _instance;
    private ScoreManager() { }

    int _score = 0;

    public void AddScore(int score)
    {
        _score += score;
    }
    public int GetScore()
    {
        return _score;
    }
}
