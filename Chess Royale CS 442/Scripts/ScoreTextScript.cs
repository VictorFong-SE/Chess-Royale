using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextScript : MonoBehaviour
{
public GameObject text; 

    void Awake() {
        text.GetComponent<UnityEngine.UI.Text>().text = "Your score: " + GoBetween.score;
    }
}
