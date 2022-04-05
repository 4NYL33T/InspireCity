using System.Collections;
using UnityEngine;


[System.Serializable]
public class ItemModel
{
    public int idI { get; }
    public string nameI { get; }

    public int amount;
    public ItemModel(int _idI, string _nameI/*, int _amount*/)
    {
        idI = _idI;
        nameI = _nameI;
        //amount = _amount;
    }
}

