using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text _text;

    void Update()
    {
        _text.text = ScoreManager.Instance.GetScore().ToString();
    }
}
