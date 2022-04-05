//using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public Canvas WindowCanvas;

    void Awake()
    {
        if (Instance == null)
        { // ��������� ��������� ��� ������
            Instance = this; // ������ ������ �� ��������� �������
        }
        else if (Instance == this)
        { // ��������� ������� ��� ���������� �� �����
            Destroy(gameObject); // ������� ������
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public assetManager AssetManager;
    public Model Model;


    void Start()
    {
        AssetManager = new assetManager();
        Window.Show("TestWindow");
        Model = new Model();
    }


    void Update()
    {
        
    }
}
