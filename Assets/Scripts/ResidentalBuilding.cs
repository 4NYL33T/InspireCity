using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentalBuilding : BuildingModel
{
    int capacity { get; }
    public ResidentalBuilding(int _costB, int _idB, int _sizexB, int _sizeyB, string _nameB, int _capacity) 
        :base(_costB, _idB, _sizexB, _sizeyB, _nameB)
    {
        capacity = _capacity;
    }
}
