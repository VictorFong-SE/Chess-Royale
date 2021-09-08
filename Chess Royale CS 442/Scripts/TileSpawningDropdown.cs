using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawningDropdown : MonoBehaviour
{
    public void HandleInputData(int val) {

        Debug.Log("tile val = "+val);

        if (val == 0) {
            GoBetween.redSpawnDiv = 14;
            GoBetween.greenSpawnDiv = 8;
        }

        if (val == 1) {
            GoBetween.redSpawnDiv = 8;
            GoBetween.greenSpawnDiv = 8;
        }

        if (val == 2) {
            GoBetween.redSpawnDiv = 5;
            GoBetween.greenSpawnDiv = 14;
        }

    }
}
