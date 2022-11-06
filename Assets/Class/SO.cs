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

public class Air 
{

    public string Name;
    public TypeAir Type;
    public int Price;
    public int Hit;
    public int Damage;
    public int Step;

}

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

public class Flotiliya
{

    public string Name;
    public List<Flot> flots;
    public double ZagStep;
    public int Price;

}

public class Division
{

    public string Name;
    public List<Polk> polks;
    public int ZagStep;
    public int Price;

}

public class Region 
{

    public string Name;
    public GameObject region;
    public GameObject town;
    public List<Division> divisions;
    public List<Build> builds;
    public int Population;

}

public class Technology 
{

    public string Name;
    public int Time;
    public List<Technology> TechsNeed;
    public List<Build> builds;
    public List<Polk> polks;
    public int PlusCiv;
    public int PlusArm;
    public int PlusCount;

}

public class Country 
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