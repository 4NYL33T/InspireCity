using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager ins;
    
    public FileData[] filesRefs;
    public Dictionary<string, BaseSerializable[]> data;

    private TextAsset[] textAssets;

    private void Awake()
    {
        if (ins == null) ins = this;
    }


    void Start()
    {
        data = new Dictionary<string, BaseSerializable[]>();
        LoadResources();
    }

    private void LoadResources() {
        textAssets = Resources.LoadAll<TextAsset>("DataBase");
        for (int i =0;i< textAssets.Length;i++) {
            int type = FindRefType(textAssets[i].name, filesRefs);
            switch (type)
            {
                case 0:
                    AddDataBlock<Difficulty>(filesRefs[type].name, textAssets[i].text);
                    break;
                case 1:
                    AddDataBlock<WeaponsShopItem>(filesRefs[type].name, textAssets[i].text);
                    break;
                case 2:
                    AddDataBlock<Weapon>(filesRefs[type].name, textAssets[i].text);
                    break;
                case 3:
                    AddDataBlock<Entity>(filesRefs[type].name, textAssets[i].text);
                    break;
                default:
                    break;
            }
        }
    }
    private void AddDataBlock<T>(string name, string str) {
        data.Add(name, CSVSerializer.Deserialize<T>(str) as BaseSerializable[]);
    }
    private int FindRefType(string str, FileData[] arr) {
        for (int i=0;i<arr.Length;i++)if (str.IndexOf(arr[i].filename) > -1) return (int)arr[i].objectType;
        return -1;
    }
}
[System.Serializable]
public struct FileData {
    public string filename;
    public string name;
    public ObjectType objectType;
}
//Список типов для сериализации
[System.Serializable]
public enum ObjectType
{
    Difficulty,
    WeaponsShopItem,
    Weapon,
    Entity
};