using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    public Dictionary<int, ItemModel> Items;
    public Dictionary<int, BuildingModel> Buildings;
    public Model()
    {
        Items = new Dictionary<int, ItemModel>();
        Items.Add(1, new ItemModel(1, "Money1"));
        Items.Add(2, new ItemModel(2, "Gems"));
        Items.Add(3, new ItemModel(3, "Happiness"));
        Items.Add(4, new ItemModel(4, "Level"));
        Items.Add(5, new ItemModel(5, "DevPoints"));
        Buildings = new Dictionary<int, BuildingModel>();
        Buildings.Add(1, new ResidentalBuilding(10, 1, 1, 1, "SmallHouse", 2));
        Buildings.Add(2, new ResidentalBuilding(20, 2, 2, 1, "MiddleHouse", 5));
        Buildings.Add(11, new IndustrialBuilding(30, 11, 1, 1, "SmallShop", 10));
        Buildings.Add(21, new AestheticBuilding(40, 21, 4, 1, "Obelisk", 10));
        //int _idB = ResBuildings[1].idB;
        //int _idI = Items[1].idI;

    }

}

