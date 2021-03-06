﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public GameManager()
    {
        Instance = this;
    }

    private static StringBuilder message = new StringBuilder();

    public void OnGUI()
    {
        //font colour
        GUI.color = Color.red;
        //background to see text better
        GUI.Box(new Rect(0, 0, 300, 110), "" ) ; 
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "" + message);
        if (Event.current.type == EventType.Repaint)
        {
            message.Length = 0;
        }
    }

    public static void Log(string text)
    {
        message.Append(text + "\n");
    }
}