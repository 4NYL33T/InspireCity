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
        { // Ёкземпл€р менеджера был найден
            Instance = this; // «адаем ссылку на экземпл€р объекта
        }
        else if (Instance == this)
        { // Ёкземпл€р объекта уже существует на сцене
            Destroy(gameObject); // ”дал€ем объект
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
