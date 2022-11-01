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

public enum TypeFlot
{
    Submarine,
    Esminec,
    Kreyser,
    Linkor,
    Airship
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
    public int Price;

}

[CreateAssetMenu(fileName = "Polk", menuName = "Create objects/Polk")]
public class Polk : ScriptableObject {

    public string Name;
    public TypePolk Type;
    public int Price;
    public int Hit;
    public int Step;

}

[CreateAssetMenu(fileName = "Flot", menuName = "Create objects/Flot")]
public class Flot : ScriptableObject
{

    public string Name;
    public TypeFlot Type;
    public int Price;
    public int Hit;
    public int Bronya;
    public int Step;

}

[CreateAssetMenu(fileName = "Flotiliya", menuName = "Create objects/Flotiliya")]
public class Flotiliya : ScriptableObject
{

    public string Name;
    public List<Flot> flots;
    public double ZagStep;

}

[CreateAssetMenu(fileName = "Division", menuName = "Create objects/Division")]
public class Division : ScriptableObject
{

    public string Name;
    public List<Polk> polks;
    public int ZagStep; 

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
    public int Money;
    public int BuildResourse;
    public int Stail;
    public int Topluvo;
    public int Kauchuk;
    public int Popularity;

}