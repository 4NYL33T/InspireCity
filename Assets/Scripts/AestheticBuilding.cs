using System.Collections;
using UnityEngine;



public class AestheticBuilding : BuildingModel
{
    int happiness { get; }
    public AestheticBuilding(int _costB, int _idB, int _sizexB, int _sizeyB, string _nameB, int _happiness)
        : base(_costB, _idB, _sizexB, _sizeyB, _nameB)
    {
        happiness = _happiness;
    }


}
