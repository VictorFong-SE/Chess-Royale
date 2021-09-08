using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndScript : MonoBehaviour
{
    public void onPlayAgainClick() {
        SceneManager.LoadScene("GameInit");
    }

    public void onMainMenuClick() {
        GoBetween.score = 0;
        SceneManager.LoadScene("MainMenu");
    }

}
