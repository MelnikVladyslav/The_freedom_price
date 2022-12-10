using System.Collections;
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
            },
            //Ukraine
            //16
            new Region()
            {
                Name = "Kyiv",
                town = towns[16],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 23035
            },
            //17
            new Region()
            {
                Name = "Bilgorod-Dnistrovskiy",
                town = towns[17],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 18928
            },
            //18
            new Region()
            {
                Name = "Zhutomur",
                town = towns[18],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17653
            },
            //19
            new Region()
            {
                Name = "Hmelnitskiy",
                town = towns[19],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 20099
            },
            //20
            new Region()
            {
                Name = "Vinnytsa",
                town = towns[20],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14825
            },
            //21
            new Region()
            {
                Name = "White Church",
                town = towns[21],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17302
            },
            //22
            new Region()
            {
                Name = "Uman",
                town = towns[22],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13275
            },
            //23
            new Region()
            {
                Name = "Odessa",
                town = towns[23],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8515
            },
            //24
            new Region()
            {
                Name = "Mukolaiv",
                town = towns[24],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 10091
            },
            //25
            new Region()
            {
                Name = "Kruvuy Rig",
                town = towns[25],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8915
            },
            //26
            new Region()
            {
                Name = "Kherson",
                town = towns[26],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8918
            },
            //27
            new Region()
            {
                Name = "Sevastopol",
                town = towns[27],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22225
            },
            //28
            new Region()
            {
                Name = "Melitopol",
                town = towns[28],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8691
            },
            //29
            new Region()
            {
                Name = "Zaporichya",
                town = towns[29],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 10245
            },
            //30
            new Region()
            {
                Name = "Dnipro",
                town = towns[30],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14365
            },
            //31
            new Region()
            {
                Name = "Chernigiv",
                town = towns[31],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9797
            },
            //32
            new Region()
            {
                Name = "Symu",
                town = towns[32],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13801
            },
            //33
            new Region()
            {
                Name = "Donbas",
                town = towns[33],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14533
            },
            //34
            new Region()
            {
                Name = "Krasnodar",
                town = towns[34],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17358
            },
            //35
            new Region()
            {
                Name = "Cherkasu",
                town = towns[35],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 15358
            },
            //36
            new Region()
            {
                Name = "Belgorod",
                town = towns[36],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13712
            },
            //37
            new Region()
            {
                Name = "Kursk",
                town = towns[37],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9027
            },
            //38
            new Region()
            {
                Name = "Bryansk",
                town = towns[38],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13683
            },
            //39
            new Region()
            {
                Name = "Kerch",
                town = towns[39],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8435
            },
            //40
            new Region()
            {
                Name = "Brest",
                town = towns[40],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9564
            },
            //41
            new Region()
            {
                Name = "Poltava",
                town = towns[41],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13916
            },
            //42
            new Region()
            {
                Name = "Kharkiv",
                town = towns[42],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 12790
            },
            //43
            new Region()
            {
                Name = "Rozsoch",
                town = towns[43],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 10188
            },
            //44
            new Region()
            {
                Name = "Chernivci",
                town = towns[44],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 16828
            },
            //45
            new Region()
            {
                Name = "Uzgorod",
                town = towns[45],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13423
            },
            //46
            new Region()
            {
                Name = "Ivano-Frankivsk",
                town = towns[46],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 18120
            },
            //47
            new Region()
            {
                Name = "Ternopil",
                town = towns[47],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19036
            },
            //48
            new Region()
            {
                Name = "Rivne",
                town = towns[48],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14948
            },
            //49
            new Region()
            {
                Name = "Lutsk",
                town = towns[49],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14313
            },
            //50
            new Region()
            {
                Name = "Lviv",
                town = towns[50],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 19232
            },
            //Albania
            //51
            new Region()
            {
                Name = "Tirana",
                town = towns[51],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 23360
            },
            //Grecia
            //52
            new Region()
            {
                Name = "Afinu",
                town = towns[52],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24976
            },
            //53
            new Region()
            {
                Name = "Saloniku",
                town = towns[53],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 16446
            },
            //54
            new Region()
            {
                Name = "Larisa",
                town = towns[54],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 12424
            },
            //55
            new Region()
            {
                Name = "Yoniana",
                town = towns[55],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9220
            },
            //Turcia
            //56
            new Region()
            {
                Name = "Ankara",
                town = towns[56],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 20321
            },
            //57
            new Region()
            {
                Name = "Stanbull",
                town = towns[57],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25512
            },
            //58
            new Region()
            {
                Name = "Bursa",
                town = towns[58],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14790
            },
            //59
            new Region()
            {
                Name = "Eskishehir",
                town = towns[59],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8253
            },
            //60
            new Region()
            {
                Name = "Izmir",
                town = towns[60],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13349
            },
            //61
            new Region()
            {
                Name = "Antalia",
                town = towns[61],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 12809
            },
            //62
            new Region()
            {
                Name = "Konya",
                town = towns[62],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8852
            },
            //63
            new Region()
            {
                Name = "Mersin",
                town = towns[63],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14225
            },
            //64
            new Region()
            {
                Name = "Adana",
                town = towns[64],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13440
            },
            //65
            new Region()
            {
                Name = "Gazintem",
                town = towns[65],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14082
            },
            //66
            new Region()
            {
                Name = "Kayseri",
                town = towns[66],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8489
            },
            //67
            new Region()
            {
                Name = "Ordu",
                town = towns[67],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14037
            },
            //68
            new Region()
            {
                Name = "Malatya",
                town = towns[68],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14113
            },
            //Bolgaria
            //69
            new Region()
            {
                Name = "Sofia",
                town = towns[69],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8424
            },
            //70
            new Region()
            {
                Name = "Varna",
                town = towns[70],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 13143
            },
            //71
            new Region()
            {
                Name = "Plovdiv",
                town = towns[71],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 14697
            },
            //Yugoslavia
            //72
            new Region()
            {
                Name = "Belgrade",
                town = towns[72],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25929
            },
            //73
            new Region()
            {
                Name = "Kosovo",
                town = towns[73],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8716
            },
            //74
            new Region()
            {
                Name = "Skope",
                town = towns[74],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22314
            },
            //75
            new Region()
            {
                Name = "Podgorica",
                town = towns[75],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9199
            },
            //76
            new Region()
            {
                Name = "Saraevo",
                town = towns[76],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //77
            new Region()
            {
                Name = "Zagreb",
                town = towns[77],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //78
            new Region()
            {
                Name = "Lublyana",
                town = towns[78],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 21551
            },
            //Rumunia
            //79
            new Region()
            {
                Name = "Buharest",
                town = towns[79],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25929
            },
            //80
            new Region()
            {
                Name = "Konstanca",
                town = towns[80],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8716
            },
            //81
            new Region()
            {
                Name = "Kuchuniv",
                town = towns[81],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22314
            },
            //82
            new Region()
            {
                Name = "Iasi",
                town = towns[82],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9199
            },
            //83
            new Region()
            {
                Name = "Cluj-Napoka",
                town = towns[83],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //84
            new Region()
            {
                Name = "Timisoara",
                town = towns[84],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //sssr
            //85
            new Region()
            {
                Name = "moskva",
                town = towns[85],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25929
            },
            //86
            new Region()
            {
                Name = "minsk",
                town = towns[86],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8716
            },
            //87
            new Region()
            {
                Name = "smolensk",
                town = towns[87],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22314
            },
            //88
            new Region()
            {
                Name = "pskov",
                town = towns[88],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9199
            },
            //89
            new Region()
            {
                Name = "orel",
                town = towns[89],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //90
            new Region()
            {
                Name = "velikiy novgorod",
                town = towns[90],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //91
            new Region()
            {
                Name = "voronezh",
                town = towns[91],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 25929
            },
            //92
            new Region()
            {
                Name = "rostov-na-donu",
                town = towns[92],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8716
            },
            //93
            new Region()
            {
                Name = "gomel",
                town = towns[93],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22314
            },
            //94
            new Region()
            {
                Name = "vitebsk",
                town = towns[94],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9199
            },
            //95
            new Region()
            {
                Name = "tver",
                town = towns[95],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //96
            new Region()
            {
                Name = "kaluga",
                town = towns[96],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //97
            new Region()
            {
                Name = "tula",
                town = towns[97],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //98
            new Region()
            {
                Name = "mogulev",
                town = towns[98],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Poland
            //99
            new Region()
            {
                Name = "Warshava",
                town = towns[99],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8716
            },
            //100
            new Region()
            {
                Name = "Lublin",
                town = towns[100],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 22314
            },
            //101
            new Region()
            {
                Name = "Krakov",
                town = towns[101],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 9199
            },
            //102
            new Region()
            {
                Name = "Lodz",
                town = towns[102],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //103
            new Region()
            {
                Name = "Poznan",
                town = towns[103],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //104
            new Region()
            {
                Name = "Bilyastok",
                town = towns[104],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 8748
            },
            //105
            new Region()
            {
                Name = "Gdinya",
                town = towns[105],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //106
            new Region()
            {
                Name = "Grodno",
                town = towns[106],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Ugorchina
            //107
            new Region()
            {
                Name = "Budapest",
                town = towns[107],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //108
            new Region()
            {
                Name = "Debrecen",
                town = towns[108],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Lutva
            //109
            new Region()
            {
                Name = "Vilnus",
                town = towns[109],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //110
            new Region()
            {
                Name = "Memel",
                town = towns[110],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Latvia
            //111
            new Region()
            {
                Name = "Riga",
                town = towns[111],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //112
            new Region()
            {
                Name = "Rezekne",
                town = towns[112],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Estonia
            //113
            new Region()
            {
                Name = "Talin",
                town = towns[113],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //114
            new Region()
            {
                Name = "Tartu",
                town = towns[114],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Norwagy
            //115
            new Region()
            {
                Name = "Oslo",
                town = towns[115],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //116
            new Region()
            {
                Name = "Kristance",
                town = towns[116],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Sweden
            //117
            new Region()
            {
                Name = "Stokgolm",
                town = towns[117],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //118
            new Region()
            {
                Name = "Geterborg",
                town = towns[118],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //119
            new Region()
            {
                Name = "Malme",
                town = towns[119],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Daniya
            //120
            new Region()
            {
                Name = "Coppengagen",
                town = towns[120],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //121
            new Region()
            {
                Name = "Olborg",
                town = towns[121],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
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
