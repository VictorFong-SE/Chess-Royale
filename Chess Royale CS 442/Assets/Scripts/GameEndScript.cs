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
        SceneManager.LoadScene("MainMenu");
    }

}
