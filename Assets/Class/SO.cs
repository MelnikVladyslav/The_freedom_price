using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

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
    Alliens,
    Marionetka
}

public enum Idelogies
{
    Neutrall,
    Communism,
    Fascism,
    Nationalism,
    Democraty,
    Monarchy,
    Anarchy
}

public enum TypeTech
{
    Civil,
    Viyskov,
    Army,
    Technika,
    Air,
    Flot,
    Country,
    LandDoctrine,
    AirDoctrine,
    FlotDoctrine
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
    public int kilkTurns = 2;

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
    public Texture icon;

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
    public int kilkturns = 2;

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
    public int kilkturns = 2;

}

[Serializable]
public class Division
{

    public string Name;
    public List<Polk> polks = new List<Polk>();
    public int ZagHit = 0;
    public int ZagBr = 0;
    public int ZagDam = 0;
    public int ZagStep = 0;
    public int kilkRec = 0;
    public int Price = 0;
    public int kilkturns;

}

[Serializable]
public class Region 
{

    public string Name;
    public GameObject region;
    public GameObject town;
    public List<Division> divisions = new List<Division>();
    public List<Flot> flotiliya = new List<Flot>();
    public List<Air> airs = new List<Air>();
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
    public bool isOpen = false;
    public TypeTech typeTech;
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
    public List<Division> shablons = new List<Division>();
    public List<Polk> openPolks = new List<Polk>();
    public List<Build> openBuilds = new List<Build>();
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
    public Texture Flag;

}