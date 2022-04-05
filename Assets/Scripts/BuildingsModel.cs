using System.Collections;
using UnityEngine;

public class BuildingModel
{
    public int costB{ get; }
    public int idB { get; }
    public int sizexB { get; }
    public int sizeyB { get; }
    public string nameB { get; }
  
        public BuildingModel(int _costB, int _idB, int _sizexB, int _sizeyB, string _nameB)
    {
        costB = _costB;
        idB = _idB;
        sizexB = _sizexB;
        sizeyB = _sizeyB;
        nameB = _nameB;
    }


}
