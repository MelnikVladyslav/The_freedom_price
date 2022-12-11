using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

public enum TypeAir
{
    Fighter,
    Bomber
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

[Serializable]
public class Build
{
    public string Name;
    public TypeBuild Type;
    public int Price;
    public int Dohid;
    public int ZnArmy;
    public int Hit;
    public int Damage;

}

[Serializable]
public class Polk
{

    public string Name;
    public TypePolk Type;
    public int Price;
    public int Hit;
    public int Damage;
    public int Step;
    public int Bronya;

}

[Serializable]
public class Air 
{

    public string Name;
    public TypeAir Type;
    public int Price;
    public int Hit;
    public int Damage;
    public int Step;

}

[Serializable]
public class Flot
{

    public string Name;
    public TypeFlot Type;
    public int Price;
    public int Hit;
    public int Damage;
    public int Bronya;
    public int Step;

}

[Serializable]
public class Flotiliya
{

    public string Name;
    public List<Flot> flots = new List<Flot>();
    public double ZagStep;
    public int Price;

}

[Serializable]
public class Division
{

    public string Name;
    public List<Polk> polks = new List<Polk>();
    public int ZagStep;
    public int Price;

}

[Serializable]
public class Region 
{

    public string Name;
    public GameObject region;
    public GameObject town;
    public List<Division> divisions = new List<Division>();
    public List<Flotiliya> flotiliya = new List<Flotiliya>();
    public List<Build> builds;
    public int Population;

}

[Serializable]
public class Technology 
{

    public string Name;
    public int Time;
    public List<Build> builds = new List<Build>();
    public List<Polk> polks = new List<Polk>();
    public int PlusCiv;
    public int PlusArm;
    public int PlusCount;

}

[Serializable]
public class Country 
{

    public string Name;
    public TypeCountry Types;
    public int PopulationCount;
    public string NameAlliens;
    public List<Region> regions = new List<Region>();
    public List<Technology> techs = new List<Technology>();
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