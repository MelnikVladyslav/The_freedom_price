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

public enum TypeCountry
{
    Neutrall,
    Player,
    Enemy,
    Alliens
}

public enum Idelogies
{
    Neutrall,
    Communism,
    Fascism,
    Nationalism,
    Democraty,
    Monarchy
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

[CreateAssetMenu(fileName = "Division", menuName = "Create objects/Division")]
public class Division : ScriptableObject
{

    public string Name;
    public List<Polk> polks;

}

[CreateAssetMenu(fileName = "Region", menuName = "Create objects/Region")]
public class Region : ScriptableObject
{

    public string Name;
    public GameObject region;
    public GameObject town;
    public List<Division> divisions;
    public List<Build> builds;
    public int Population;

}

[CreateAssetMenu(fileName = "Technology", menuName = "Create objects/Technology")]
public class Technology : ScriptableObject
{

    public string Name;
    public int Time;
    public List<Technology> TechsNeed;
    public List<Build> builds;
    public List<Polk> polks; 

}

[CreateAssetMenu(fileName = "Country", menuName = "Create objects/Country")]
public class Country : ScriptableObject
{

    public string Name;
    public TypeCountry Types;
    public int PopulationCount;
    public string NameAlliens;
    public List<Region> regions;
    public List<Technology> techs;
    public Idelogies idelogy;
    public int Stabilnisty;
    public int ProcentViyskovoZob;
    public int KilkistyRecruit;

}