using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GoBetween
{
    // Set/read these variables to carry information between scenes

    // game options
    public static int boardSize = 16;
    public static int redSpawnDiv = 14;
    public static int greenSpawnDiv = 8;
    public static int shrinkSpeed = 2;

    // player stats
    public static bool hasWon = false;
    public static int captures = 0;
    public static int downgrades = 0;
    public static int moves = 0;
    public static int score = 0;
    public static string color = "white";

}
