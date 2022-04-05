using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataManager1 : MonoBehaviour {


    TextAsset textAssetData;

    int tablesize;
    public int rowsize;
    public int columns;
    private string itemName;

    public Dictionary<string, ItemModel> allItems;

    void Start()
    {

    }

    void ReadCSV()
    {
      string[] data=textAssetData.text.Split(new string[] {",", "\n"}, StringSplitOptions.None);
      
      allItems=new Dictionary<string, ItemModel>();
      tablesize = data.Length;

      for(int i=1; i<columns; i++)
      {
        itemName = data[rowsize * i];
        allItems.Add(itemName, new ItemModel(int.Parse(data[rowsize*i+1]),itemName));
      }
    }

}

