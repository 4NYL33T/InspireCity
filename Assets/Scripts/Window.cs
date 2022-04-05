using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window : MonoBehaviour
{
    int QueuePosition;

    //List<Button> Buttons;
    private int ButtonsLength;

    public bool importance;

    public Button CloseBtn;
    public Button YBtn;
    public Button NBtn;

    public static void Show(string wndname)
    {
        GameObject wndobj = Main.Instance.AssetManager.GetAsset("Windows/" + wndname, "Windows");
        wndobj = Instantiate(wndobj, Main.Instance.WindowCanvas.transform);
        Window wnd = wndobj.GetComponent<Window>();
        WindowManager.ShowWindow(wnd, wnd.importance);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowWindow()
    {
        CloseBtn.onClick.AddListener(CloseWindow);
        
    }

    public void CloseWindow()
    {
        CloseBtn.onClick.RemoveAllListeners();

        WindowManager.CloseWindow(this);
        Destroy(this.gameObject);
    }

}
