using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusTextScript : MonoBehaviour
{
    public GameObject text; 

    void Awake() {
        if (GoBetween.hasWon == false) {
            text.GetComponent<UnityEngine.UI.Text>().text = "You Lost!";
            text.GetComponent<UnityEngine.UI.Text>().color = Color.red;
        } else {
            text.GetComponent<UnityEngine.UI.Text>().text = "You Won!";
            text.GetComponent<UnityEngine.UI.Text>().color = Color.green;
        }
    }
}
