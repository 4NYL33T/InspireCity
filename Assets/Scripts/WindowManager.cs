using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager
{

    public static List<Window> Queue = new List<Window>();
    public static List<Window> Opened = new List<Window>();


    public Button BackButton;

    public static void ShowWindow(Window wnd, bool important)
    {
        if (important || Opened.Count == 0)
        {
            AddToOpened(wnd);
        }
        else
        {
            AddToQueue(wnd);
        }
    }

    public static void AddToOpened(Window wnd)
    {
        Opened.Add(wnd);
        wnd.ShowWindow();
        wnd.gameObject.SetActive(true);
    }

    public static void AddToQueue(Window wnd)
    {
        Queue.Add(wnd);
        wnd.gameObject.SetActive(false);
    }

    public static void CloseWindow(Window wnd)
    {
        for(int i=0; i<Opened.Count; i++)
        {
            if(Opened[i]==wnd)
            { Opened.Remove(Opened[i]); }
        }
        if(Opened.Count==0 && Queue.Count>0)
        {
            AddToOpened(Queue[0]);
            Queue.Remove(Queue[0]);
        }
    }

    public static void CloseEmpty()
    {
        int i = 0;
        while (i < Opened.Count)
        {
            if(Opened[i]==null)
            { Opened.Remove(Opened[i]); }
            else
            { i++; }
        }
        i = 0;
        while (i < Queue.Count)
        {
            if (Queue[i] == null)
            { Queue.Remove(Queue[i]); }
            else
            { i++; }
        }
    }

}
