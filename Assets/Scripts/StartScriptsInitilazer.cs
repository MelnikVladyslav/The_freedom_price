﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScriptsInitilazer : MonoBehaviour
{
    List<Country> CountryList;
    List<Technology> TechnologyList;
    List<Polk> PolkList;
    List<Build> BuildList;
    List<Air> AirList;
    List<Flot> FlotList;
    List<Region> RegionList;
    public List<GameObject> towns = new List<GameObject>();

    public void Start()
    {
        CreateLists();
        InitilizerCountry();
    }
    public void Update()
    {

    }

    void CreateLists()
    {
        PolkList = new List<Polk>()
        { 
            new Polk
            {
                Name = "Garrizon",
                Type = TypePolk.Garrison,
                Price = 50,
                Hit = 50,
                Damage = 20,
                Bronya = 0,
                Step = 1
            },
            new Polk
            {
                Name = "Pihota",
                Type = TypePolk.Pihota,
                Price = 100,
                Hit = 100,
                Damage = 30,
                Bronya = 0,
                Step = 1
            },
            new Polk
            {
                Name = "Artillery",
                Type = TypePolk.Artilery,
                Price = 150,
                Hit = 100,
                Damage = 40,
                Bronya = 0,
                Step = 1
            },
            new Polk
            {
                Name = "Btr",
                Type = TypePolk.Btr,
                Price = 200,
                Hit = 150,
                Damage = 30,
                Bronya = 10,
                Step = 2
            },
            new Polk
            {
                Name = "Motorized",
                Type = TypePolk.Motorized,
                Price = 150,
                Hit = 150,
                Damage = 30,
                Bronya = 0,
                Step = 3
            },
            new Polk
            {
                Name = "Mechanized",
                Type = TypePolk.Mehanized,
                Price = 200,
                Hit = 200,
                Damage = 40,
                Bronya = 20,
                Step = 3
            },
            new Polk
            {
                Name = "Light Tank",
                Type = TypePolk.LightTanks,
                Price = 250,
                Hit = 250,
                Damage = 50,
                Bronya = 30,
                Step = 2
            },
            new Polk
            {
                Name = "Medium Tank",
                Type = TypePolk.MediumTanks,
                Price = 300,
                Hit = 300,
                Damage = 60,
                Bronya = 40,
                Step = 2
            },
            new Polk
            {
                Name = "Heavy Tank",
                Type = TypePolk.HeavyTanks,
                Price = 350,
                Hit = 350,
                Damage = 70,
                Bronya = 50,
                Step = 2
            }
        };
        BuildList = new List<Build>()
        {
            new Build
            {
                Name = "Silske gospodarstvo",
                Type = TypeBuild.Lehka,
                Price = 100,
                Dohid = 100
            },
            new Build
            {
                Name = "Civilian promuslovisty",
                Type = TypeBuild.Lehka,
                Price = 500,
                Dohid = 250
            },
            new Build
            {
                Name = "Army factory",
                Type = TypeBuild.Big,
                Price = 500,
                ZnArmy = 10
            },
            new Build
            {
                Name = "Bunker",
                Type = TypeBuild.Defend,
                Price = 250,
                Hit = 100,
                Damage = 50
            },
            new Build
            {
                Name = "PVO",
                Type = TypeBuild.Defend,
                Price = 200,
                Hit = 100,
                Damage = 50
            }
        };
        AirList = new List<Air>()
        {
            new Air
            {
                Name = "Fighter",
                Type = TypeAir.Fighter,
                Price = 1000,
                Hit = 100,
                Damage = 50,
                Step = 5
            },
            new Air
            {
                Name = "Bomber",
                Type = TypeAir.Bomber,
                Price = 1500,
                Hit = 100,
                Damage = 50,
                Step = 5
            }
        };
        FlotList = new List<Flot>()
        {
            new Flot
            {
                Name = "Submarine",
                Type = TypeFlot.Submarine,
                Price = 100,
                Hit = 100,
                Damage = 20,
                Bronya = 10,
                Step = 1
            },
            new Flot
            {
                Name = "Esminec",
                Type = TypeFlot.Esminec,
                Price = 150,
                Hit = 150,
                Damage = 30,
                Bronya = 20,
                Step = 1
            },
            new Flot
            {
                Name = "Kreyser",
                Type = TypeFlot.Kreyser,
                Price = 200,
                Hit = 200,
                Damage = 40,
                Bronya = 30,
                Step = 1
            },
            new Flot
            {
                Name = "Linkor",
                Type = TypeFlot.Linkor,
                Price = 250,
                Hit = 250,
                Damage = 50,
                Bronya = 40,
                Step = 1
            },
            new Flot
            {
                Name = "Airship",
                Type = TypeFlot.Airship,
                Price = 300,
                Hit = 300,
                Damage = 60,
                Bronya = 50,
                Step = 1
            }
        };
        TechnologyList = new List<Technology>()
        {
            //1935
            //0
            new Technology
            {
                Name = "Basic technology",
                Time = 0
            },
            //1936
            // Civil
            //1
            new Technology
            {
                Name = "Construction I",
                Time = 2,
                PlusCiv = 10 // silskGospod
            },
            // Viyskova pr
            //2
            new Technology
            {
                Name = "Basic machine tools",
                Time = 2,
                PlusArm = 2
            },
            // Country bonus
            //3
            new Technology
            {
                Name = "Electronic mechanical engineering",
                Time = 2,
                PlusCount = 1 //stabilnisty
            },
            //Army
            //4
            new Technology
            {
                Name = "Infantry Equipment I",
                Time = 2,
                PlusArm = 5 // Add hit and damage Garrizon and Pihota polks
            },
            //5
            new Technology
            {
                Name = "Motorized",
                Time = 2
            },
            // Technika
            //6
            new Technology
            {
                Name = "Light Tank I",
                Time = 2
            },
            //Air
            //7
            new Technology
            {
                Name = "Fighter I and Bomber I",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            //Flot
            //8
            new Technology
            {
                Name = "Flot I",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //9
            new Technology
            {
                Name = "Mobile Warfare",
                Time = 2
            },
            //10
            new Technology
            {
                Name = "Superior Firepower",
                Time = 2,
                PlusArm = 5 // Add damage artillery
            },
            //11
            new Technology
            {
                Name = "Trench Warfare",
                Time = 2
            },
            //12
            new Technology
            {
                Name = "Mass Assault",
                Time = 2,
                PlusArm = 5 // Minus 5% to price pihota
            },
            // Air doctrines
            //13
            new Technology
            {
                Name = "Air Superiority",
                Time = 2,
                PlusArm = 5 // Add damage fighters
            },
            //14
            new Technology
            {
                Name = "Formation Flying",
                Time = 2,
                PlusArm = 7 // Add damage fighters
            },
            //15
            new Technology
            {
                Name = "Force Rotation",
                Time = 2,
                PlusArm = 8 // Add Hit fighters
            },
            // Naval doctrines
            //16
            new Technology
            {
                Name = "Fleet In Being",
                Time = 2,
                PlusArm = 5 // Add damage and hit esminec, kreyser and linkor
            },
            //17
            new Technology
            {
                Name = "Trade Interdiction",
                Time = 2,
                PlusArm = 5 // Add damage and hit esminec and submarine
            },
            //18
            new Technology
            {
                Name = "Base Strike",
                Time = 2,
                PlusArm = 5 // Add damage and hit airship and bombers
            },
            //1937
            // Civil
            //19
            new Technology
            {
                Name = "Construction II",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //20
            new Technology
            {
                Name = "Improved machine tools",
                Time = 2,
                PlusArm = 2
            },
            // Country bonus
            //21
            new Technology
            {
                Name = "Radio",
                Time = 2,
                PlusCount = 3 //stabilnisty
            },
            //Flot
            //22
            new Technology
            {
                Name = "Flot II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //23
            new Technology
            {
                Name = "Delay Mob War",
                Time = 2,
                PlusArm = 5 // Add hit pihota and motorized/mehanized
            },
            //24
            new Technology
            {
                Name = "Delay",
                Time = 2,
                PlusArm = 3 // Add hit pihota
            },
            //25
            new Technology
            {
                Name = "Grand Battle Plan",
                Time = 2,
                PlusArm = 7 // Zmenchenya price for polks 
            },
            //26
            new Technology
            {
                Name = "Pocket Defense",
                Time = 2,
                PlusArm = 5 // Add 5% to hit polks in kotels
            },
            // Air doctrines
            //27
            new Technology
            {
                Name = "Infrastructure Destruction",
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //28
            new Technology
            {
                Name = "Dive Bombing",
                Time = 2,
                PlusArm = 7 // Add damage airships
            },
            //29
            new Technology
            {
                Name = "Fighter Baiting",
                Time = 2,
                PlusArm = 8 // Add Hit fighters
            },
            // Naval doctrines
            //30
            new Technology
            {
                Name = "Submarine Operations",
                Time = 2,
                PlusArm = 5 // Add damage and hit submarines
            },
            //31
            new Technology
            {
                Name = "Carrier Operations",
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //32
            new Technology
            {
                Name = "Convoy Escorts",
                Time = 2,
                PlusArm = 5 // Add damage and hit esminecs
            },
            //1938
            // Civil
            //33
            new Technology
            {
                Name = "Construction III",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //34
            new Technology
            {
                Name = "Advanced machine tools",
                Time = 2,
                PlusArm = 2
            },
            // Army
            //35
            new Technology
            {
                Name = "Improved Infantry Equipment I",
                Time = 2,
                PlusArm = 5 //Add damage garrizon, pihota and motorized/mechanized polks
            },
            // Country bonus
            //36
            new Technology
            {
                Name = "Decimetric radar",
                Time = 2,
                PlusCount = 3 //stabilnisty
            },
            //Flot
            //37
            new Technology
            {
                Name = "Flot III",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //38
            new Technology
            {
                Name = "Elastic Defense",
                Time = 2,
                PlusArm = 5 // Add bronya tanks and btrs
            },
            //39
            new Technology
            {
                Name = "Mobile Defense",
                Time = 2,
                PlusArm = 5 // Add bronya pihota, garrizons and motorized/mechanized
            },
            //40
            new Technology
            {
                Name = "Prepared Defense",
                Time = 2,
                PlusArm = 7 // Add bronya pihota, garrizons and motorized/mechanized
            },
            //41
            new Technology
            {
                Name = "Defense in Depth",
                Time = 2,
                PlusArm = 5 // Add 5 to hit pihota polks
            },
            // Air doctrines
            //42
            new Technology
            {
                Name = "Naval Strike Tactics",
                Time = 2,
                PlusArm = 5 // Add damage airships
            },
            //43
            new Technology
            {
                Name = "Direct Ground Support",
                Time = 2,
                PlusArm = 7 // Add hit fighters
            },
            //44
            new Technology
            {
                Name = "Low Echelon Support",
                Time = 2,
                PlusArm = 8 // Add hit fighters
            },
            // Naval doctrines
            //45
            new Technology
            {
                Name = "Convoy Escorts in Being",
                Time = 2,
                PlusArm = 5 // Add damage and hit esminecs
            },
            //46
            new Technology
            {
                Name = "Capital Ship Raiders",
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //47
            new Technology
            {
                Name = "Undersea Blockade",
                Time = 2,
                PlusArm = 5 // Add damage and hit submarinecs
            },
            //1939
            // Civil
            //48
            new Technology
            {
                Name = "Construction IV",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //49
            new Technology
            {
                Name = "Infantry Equipment II",
                Time = 2,
                PlusArm = 5 //Add damage garrizon, pihota polks
            },
            // Technika
            //50
            new Technology
            {
                Name = "Medium Tank I",
                Time = 2
            },
            // Country bonus
            //51
            new Technology
            {
                Name = "Improved decimetric radar",
                Time = 2,
                PlusCount = 5 //stabilnisty
            },
            //Flot
            //52
            new Technology
            {
                Name = "Flot IV",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //53
            new Technology
            {
                Name = "Armored Spearhead",
                Time = 2,
                PlusArm = 5 // Add damage tanks
            },
            //54
            new Technology
            {
                Name = "Dispersed Support",
                Time = 2,
                PlusArm = 5 // Add hit artillery
            },
            //55
            new Technology
            {
                Name = "Grand Assault",
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //56
            new Technology
            {
                Name = "People's Army",
                Time = 2,
                PlusArm = 5 // Add 5 to hit garrizon polks
            },
            // Air doctrines
            //57
            new Technology
            {
                Name = "Dogfighting Experience",
                Time = 2,
                PlusArm = 5 // Add damage fighters
            },
            //58
            new Technology
            {
                Name = "Fighter Ace Initiative",
                Time = 2,
                PlusArm = 7 // Add hit and damage airs
            },
            //59
            new Technology
            {
                Name = "Dispersed Fighting",
                Time = 2,
                PlusArm = 8 // Add hit fighters
            },
            // Naval doctrines
            //60
            new Technology
            {
                Name = "Convoy Interdiction",
                Time = 2,
                PlusArm = 5 // Add damage and hit submarines
            },
            //61
            new Technology
            {
                Name = "Subsidiary Carrier Role",
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //62
            new Technology
            {
                Name = "Floating Airfield",
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //1940
            // Civil
            //63
            new Technology
            {
                Name = "Construction V",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //64
            new Technology
            {
                Name = "Improved Infantry Equipment II",
                Time = 2,
                PlusArm = 5 ////Add damage garrizon, pihota and motorized/mechanized polks
            },
            //65
            new Technology
            {
                Name = "Mechanized Equipment I",
                Time = 2
            },
            // Air
            //66
            new Technology
            {
                Name = "Fighter II and Bomber II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Country bonus
            //67
            new Technology
            {
                Name = "Centimetric radar",
                Time = 2,
                PlusCount = 7 //stabilnisty
            },
            //Flot
            //68
            new Technology
            {
                Name = "Flot V",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //69
            new Technology
            {
                Name = "Schwerpunkt",
                Time = 2,
                PlusArm = 5 // Add hit and bronya tanks
            },
            //70
            new Technology
            {
                Name = "Overwhelming Firepower",
                Time = 2,
                PlusArm = 5 // Add damage artillery
            },
            //71
            new Technology
            {
                Name = "Mechanized Offensive",
                Time = 2,
                PlusArm = 7 // Add hit garrizons, pihota, motorized/mechanized polks
            },
            //72
            new Technology
            {
                Name = "Infantry Offensive",
                Time = 2,
                PlusArm = 5 // Add 5 to hit pihota polks
            },
            // Air doctrines
            //73
            new Technology
            {
                Name = "Multi-Altitude Flying",
                Time = 2,
                PlusArm = 5 // Add hit fighters
            },
            //74
            new Technology
            {
                Name = "Hunt and Destroy",
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //75
            new Technology
            {
                Name = "Operational Destruction",
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //76
            new Technology
            {
                Name = "Integrated Convoy Defense",
                Time = 2,
                PlusArm = 5 // Add damage and hit kreysers
            },
            //77
            new Technology
            {
                Name = "Advanced Submarine Warfare",
                Time = 2,
                PlusArm = 5 // Add damage and hit submarine
            },
            //78
            new Technology
            {
                Name = "Submarine Offensive",
                Time = 2,
                PlusArm = 5 // Add damage and hit submarine
            },
            //1941
            // Civil
            //79
            new Technology
            {
                Name = "Construction VI",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //80
            new Technology
            {
                Name = "Assembly line production",
                Time = 2,
                PlusArm = 2
            },
            // Technika
            //81
            new Technology
            {
                Name = "Light Tank II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage light tank
            },
            //82
            new Technology
            {
                Name = "Medium Tank II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage medium tank
            },
            //83
            new Technology
            {
                Name = "Heavy Tank II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage heavy tank
            },
            // Country bonus
            //84
            new Technology
            {
                Name = "Improved centimetric radar",
                Time = 2,
                PlusCount = 9 //stabilnisty
            },
            // Land doctrines
            //85
            new Technology
            {
                Name = "Blitzkrieg",
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            //86
            new Technology
            {
                Name = "Mechanized Offensive",
                Time = 2,
                PlusArm = 5 // Add bronya tanks
            },
            //87
            new Technology
            {
                Name = "Assault Concentration",
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //88
            new Technology
            {
                Name = "Large Front Offensive",
                Time = 2,
                PlusArm = 5 // Add hit pihota polks
            },
            // Air doctrines
            //89
            new Technology
            {
                Name = "Logistical Bombing",
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //90
            new Technology
            {
                Name = "Combat Unit Destruction",
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //91
            new Technology
            {
                Name = "Ground Attack Veteran Initiative",
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //92
            new Technology
            {
                Name = "Floating Airfield",
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //93
            new Technology
            {
                Name = "Combined Operations Raiding",
                Time = 2,
                PlusArm = 5 // Add damage and hit flots
            },
            //94
            new Technology
            {
                Name = "Floating Fortress",
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //1942
            // Civil
            //95
            new Technology
            {
                Name = "Construction VII",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //96
            new Technology
            {
                Name = "Infantry Anti-Tank I",
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks protu techniks
            },
            //97
            new Technology
            {
                Name = "Mechanized Equipment II",
                Time = 2,
                PlusArm = 10 // Add Hit and Damage mehanized polks
            },
            // Country bonus
            //98
            new Technology
            {
                Name = "Advanced centimetric radar",
                Time = 2,
                PlusCount = 11 //stabilnisty
            },
            // Land doctrines
            //99
            new Technology
            {
                Name = "Kampfgruppe",
                Time = 2,
                PlusArm = 10 // Add hit pohotas polks
            },
            //100
            new Technology
            {
                Name = "Centralized Fire Control",
                Time = 2,
                PlusArm = 5 // Add damage artillery and pihotas polks
            },
            //101
            new Technology
            {
                Name = "Branch Inter-Operation",
                Time = 2,
                PlusArm = 7 // Add damage pihotas and tanks polks
            },
            //102
            new Technology
            {
                Name = "Human Wave Offensive",
                Time = 2,
                PlusArm = 5 // Add hit pihota polks
            },
            // Air doctrines
            //103
            new Technology
            {
                Name = "Night Bombing",
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //104
            new Technology
            {
                Name = "Battlefield Support",
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //105
            new Technology
            {
                Name = "Carousel Bombing",
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //106
            new Technology
            {
                Name = "Grand Battlefleet",
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //107
            new Technology
            {
                Name = "Carrier Battlegroups",
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors and esminecs and kreysers
            },
            //1943
            // Civil
            //108
            new Technology
            {
                Name = "Construction VIII",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskov prom
            //109
            new Technology
            {
                Name = "Flexible line",
                Time = 2,
                PlusArm = 10 // viyskovPromka
            },
            // Army
            //110
            new Technology
            {
                Name = "Night Vision I",
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks protu pihotas
            },
            // Land doctrines
            //111
            new Technology
            {
                Name = "Volkssturm",
                Time = 2,
                PlusArm = 10 // Add % viyskova obovyazane
            },
            //112
            new Technology
            {
                Name = "Forward Observers",
                Time = 2,
                PlusArm = 5 // Add hit artillery
            },
            //113
            new Technology
            {
                Name = "Central Planning",
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //114
            new Technology
            {
                Name = "Guerrilla Warfare",
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            // Air doctrines
            //115
            new Technology
            {
                Name = "Massed Bomber Formations",
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //116
            new Technology
            {
                Name = "Naval Strike Torpedo Tactics",
                Time = 2,
                PlusArm = 7 // Add damage airships
            },
            //117
            new Technology
            {
                Name = "Infiltration Bombing",
                Time = 2,
                PlusArm = 8 // Add hit bombers
            },
            //1944
            // Civil
            //118
            new Technology
            {
                Name = "Construction IX",
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //119
            new Technology
            {
                Name = "Infantry Equipment III",
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks
            },
            //120
            new Technology
            {
                Name = "Mechanized Equipment III	",
                Time = 2,
                PlusArm = 10 // Add Damage mechanized polks
            },
            // Land doctrines
            //121
            new Technology
            {
                Name = "Non-Discriminatory Conscription",
                Time = 2,
                PlusArm = 10 // Add % viyskova obovyazane
            },
            //122
            new Technology
            {
                Name = "Advanced Firebases",
                Time = 2,
                PlusArm = 5 // Add bronya artillery
            },
            //123
            new Technology
            {
                Name = "C3I",
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //124
            new Technology
            {
                Name = "Guerrilla Warfare",
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            // Air doctrines
            //125
            new Technology
            {
                Name = "Flying Fortress",
                Time = 2,
                PlusArm = 5 // Add hit bombers
            },
            //126
            new Technology
            {
                Name = "Strategic Destruction",
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //127
            new Technology
            {
                Name = "Air Skirmish",
                Time = 2,
                PlusArm = 8 // Add hit airs
            }

        };
        RegionList = new List<Region>()
        { 
            //Germnany
            //0
            new Region()
            {
                Name = "Berlin",
                town = towns[0],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25712
            },
            //1
            new Region()
            {
                Name = "Szczecun",
                town = towns[1],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9024
            },
            //2
            new Region()
            {
                Name = "Breslau",
                town = towns[2],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 12988
            },
            //3
            new Region()
            {
                Name = "Drezden",
                town = towns[3],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 20663
            },
            //4
            new Region()
            {
                Name = "Leipzig",
                town = towns[4],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 18611
            },
            //5
            new Region()
            {
                Name = "Keninsberg",
                town = towns[5],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8768
            },
            //6
            new Region()
            {
                Name = "Nuenberg",
                town = towns[6],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 18674
            },
            //7
            new Region()
            {
                Name = "Munich",
                town = towns[7],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19347
            },
            //8
            new Region()
            {
                Name = "Gamburg",
                town = towns[8],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17980
            },
            //9
            new Region()
            {
                Name = "Ganover",
                town = towns[9],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19060
            },
            //10
            new Region()
            {
                Name = "Bremen",
                town = towns[10],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19389
            },
            //11
            new Region()
            {
                Name = "Rostok",
                town = towns[11],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 16932
            },
            //12
            new Region()
            {
                Name = "Dortmund",
                town = towns[12],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 20262
            },
            //13
            new Region()
            {
                Name = "Keln",
                town = towns[13],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19763
            },
            //14
            new Region()
            {
                Name = "Frankfurt",
                town = towns[14],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 18357
            },
            //15
            new Region()
            {
                Name = "Stugart",
                town = towns[15],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19704
            }
        };



        // Initilization BasicTechnology
        TechnologyList[0].builds.Add(BuildList[0]);
        TechnologyList[0].builds.Add(BuildList[2]);
        TechnologyList[0].builds.Add(BuildList[3]);
        TechnologyList[0].builds.Add(BuildList[4]);
        TechnologyList[0].polks.Add(PolkList[0]);
        TechnologyList[0].polks.Add(PolkList[1]);
        TechnologyList[0].polks.Add(PolkList[2]);
        TechnologyList[0].polks.Add(PolkList[3]);

        // Initilization technology 1936
        TechnologyList[1].builds.Add(BuildList[1]);
        TechnologyList[5].polks.Add(PolkList[4]);
        TechnologyList[6].polks.Add(PolkList[6]);

        // Initilization technology 1939
        TechnologyList[50].polks.Add(PolkList[7]);

        // Initilization technology 1940
        TechnologyList[65].polks.Add(PolkList[5]);
    }

    void InitilizerCountry()
    {
        int kilkNayn = 0;

        for (int i = 0; i < CountryList.Count; i++)
        {
            CountryList[i].Stabilnisty = 50 + (100 / CountryList[i].Popularity);
            for (int j = 0; j < CountryList[i].regions.Count; j++)
            {
                CountryList[i].PopulationCount += CountryList[i].regions[j].Population;
                for (int a = 0; a < CountryList[i].regions[j].divisions.Count; a++)
                {
                    kilkNayn += CountryList[i].regions[j].divisions[a].polks.Count * 100;
                }
            }
            CountryList[i].ProcentViyskovoZob = 10;
            CountryList[i].KilkistyRecruit = CountryList[i].PopulationCount * (100 / CountryList[i].ProcentViyskovoZob) - kilkNayn;
            CountryList[i].Money = 5000;
            CountryList[i].BuildResourse = 5000;
            CountryList[i].Stail = 2500;
            CountryList[i].Topluvo = 1000;
            CountryList[i].Kauchuk = 1000;
            CountryList[i].techs.Add(TechnologyList[0]);
        }
    }


}
