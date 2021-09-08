using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSpeedDropdown : MonoBehaviour
{
    public void HandleInputData(int val) {

        if (val == 0) {
            GoBetween.shrinkSpeed = 2;
        }

        if (val == 1) {
            GoBetween.shrinkSpeed = 3;
        }

        if (val == 2) {
            GoBetween.shrinkSpeed = 4;
        }

    }
}
