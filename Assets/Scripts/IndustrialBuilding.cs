using System.Collections;
using UnityEngine;



public class IndustrialBuilding : BuildingModel
{
    int production { get; }
    public IndustrialBuilding(int _costB, int _idB, int _sizexB, int _sizeyB, string _nameB, int _production)
        : base(_costB, _idB, _sizexB, _sizeyB, _nameB)
    {
        production = _production;
    }

}
