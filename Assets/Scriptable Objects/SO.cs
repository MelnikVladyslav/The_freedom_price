using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeBuild
{
    Lehka,
    Big,
    Defend
}

public enum TypePolk
{
    Garrison,
    Pihota,
    Artilery,
    LightTanks,
    MediumTanks,
    HeavyTanks,
    Motorized,
    Mehanized,
    Btr
}


[CreateAssetMenu(fileName = "Build", menuName = "Create objects/Build")]
public class Build : ScriptableObject
{
    public string Name;
    public TypeBuild Type;
    public string Price;

}

[CreateAssetMenu(fileName = "Polk", menuName = "Create objects/Polk")]
public class Polk : ScriptableObject {

    public string Name;
    public TypePolk Type;
    public string Price;
    public string Hit;
    public string Step;

}