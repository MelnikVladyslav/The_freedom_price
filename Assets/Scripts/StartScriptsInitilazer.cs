using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScriptsInitilazer : MonoBehaviour
{
    public List<Country> CountryList;
    public List<Technology> TechnologyList;
    public List<Polk> PolkList;
    List<Build> BuildList;
    public List<Air> AirList;
    public List<Flot> FlotList;
    public List<Region> RegionList;
    public List<Lider> liderList = new List<Lider>();
    public List<GameObject> towns = new List<GameObject>();
    public List<Texture> flags = new List<Texture>();
    public List<Texture> icons = new List<Texture>();
    public List<Texture> fotos = new List<Texture>();
    public int kilkNayn = 0;

    public void Start()
    {
        CreateLists();
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
                Step = 1,
                icon = icons[0]
            },
            new Polk
            {
                Name = "Pihota",
                Type = TypePolk.Pihota,
                Price = 100,
                Hit = 100,
                Damage = 30,
                Bronya = 0,
                Step = 1,
                icon = icons[1]
            },
            new Polk
            {
                Name = "Artillery",
                Type = TypePolk.Artilery,
                Price = 150,
                Hit = 100,
                Damage = 40,
                Bronya = 0,
                Step = 1,
                icon = icons[2]
            },
            new Polk
            {
                Name = "Btr",
                Type = TypePolk.Btr,
                Price = 200,
                Hit = 150,
                Damage = 30,
                Bronya = 10,
                Step = 2,
                icon = icons[3]
            },
            new Polk
            {
                Name = "Motorized",
                Type = TypePolk.Motorized,
                Price = 150,
                Hit = 150,
                Damage = 30,
                Bronya = 0,
                Step = 3,
                icon = icons[4]
            },
            new Polk
            {
                Name = "Mechanized",
                Type = TypePolk.Mehanized,
                Price = 200,
                Hit = 200,
                Damage = 40,
                Bronya = 20,
                Step = 3,
                icon = icons[5]
            },
            new Polk
            {
                Name = "Light Tank",
                Type = TypePolk.LightTanks,
                Price = 250,
                Hit = 250,
                Damage = 50,
                Bronya = 30,
                Step = 2,
                icon = icons[6]
            },
            new Polk
            {
                Name = "Medium Tank",
                Type = TypePolk.MediumTanks,
                Price = 300,
                Hit = 300,
                Damage = 60,
                Bronya = 40,
                Step = 2,
                icon = icons[7]
            },
            new Polk
            {
                Name = "Heavy Tank",
                Type = TypePolk.HeavyTanks,
                Price = 350,
                Hit = 350,
                Damage = 70,
                Bronya = 50,
                Step = 2,
                icon = icons[8]
            }
        };
        BuildList = new List<Build>()
        {
            new Build
            {
                Name = "Silske gospodarstvo",
                Type = TypeBuild.Lehka,
                Price = 1000,
                Dohid = 100
            },
            new Build
            {
                Name = "Civilian promuslovisty",
                Type = TypeBuild.Lehka,
                Price = 5000,
                Dohid = 250
            },
            new Build
            {
                Name = "Oil refinery",
                Type = TypeBuild.Lehka,
                Price = 5000,
                Dohid = 250
            },
            new Build
            {
                Name = "Army factory",
                Type = TypeBuild.Big,
                Price = 5000,
                ZnArmy = 10
            },
            new Build
            {
                Name = "Aiport",
                Type = TypeBuild.Big,
                Price = 5000,
                ZnArmy = 10
            },
            new Build
            {
                Name = "Port",
                Type = TypeBuild.Big,
                Price = 5000,
                ZnArmy = 10
            },
            new Build
            {
                Name = "Bunker",
                Type = TypeBuild.Defend,
                Price = 2500,
                Hit = 100,
                Damage = 50
            },
            new Build
            {
                Name = "PVO",
                Type = TypeBuild.Defend,
                Price = 2000,
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
                Price = 1000,
                Hit = 100,
                Damage = 20,
                Bronya = 10,
                Step = 1
            },
            new Flot
            {
                Name = "Esminec",
                Type = TypeFlot.Esminec,
                Price = 1500,
                Hit = 150,
                Damage = 30,
                Bronya = 20,
                Step = 1
            },
            new Flot
            {
                Name = "Kreyser",
                Type = TypeFlot.Kreyser,
                Price = 2000,
                Hit = 200,
                Damage = 40,
                Bronya = 30,
                Step = 1
            },
            new Flot
            {
                Name = "Linkor",
                Type = TypeFlot.Linkor,
                Price = 2500,
                Hit = 250,
                Damage = 50,
                Bronya = 40,
                Step = 1
            },
            new Flot
            {
                Name = "Airship",
                Type = TypeFlot.Airship,
                Price = 3000,
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
                Time = 0,
                isOpen = true
            },
            //1936
            // Civil
            //1
            new Technology
            {
                Name = "Construction I",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // silskGospod
            },
            // Viyskova pr
            //2
            new Technology
            {
                Name = "Basic machine tools",
                typeTech = TypeTech.Viyskov,
                Time = 2,
                PlusArm = 2
            },
            // Country bonus
            //3
            new Technology
            {
                Name = "Electronic mechanical engineering",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 1 //stabilnisty
            },
            //Army
            //4
            new Technology
            {
                Name = "Infantry Equipment I",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 5 // Add hit and damage Garrizon and Pihota polks
            },
            //5
            new Technology
            {
                Name = "Motorized",
                typeTech = TypeTech.Army,
                Time = 2
            },
            // Technika
            //6
            new Technology
            {
                Name = "Light Tank I",
                typeTech = TypeTech.Technika,
                Time = 2
            },
            //Air
            //7
            new Technology
            {
                Name = "Fighter I and Bomber I",
                typeTech = TypeTech.Air,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            //Flot
            //8
            new Technology
            {
                Name = "Flot I",
                typeTech = TypeTech.Flot,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //9
            new Technology
            {
                Name = "Mobile Warfare",
                typeTech = TypeTech.LandDoctrine,
                Time = 2
            },
            //10
            new Technology
            {
                Name = "Superior Firepower",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage artillery
            },
            //11
            new Technology
            {
                Name = "Trench Warfare",
                typeTech = TypeTech.LandDoctrine,
                Time = 2
            },
            //12
            new Technology
            {
                Name = "Mass Assault",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Minus 5% to price pihota
            },
            // Air doctrines
            //13
            new Technology
            {
                Name = "Air Superiority",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage fighters
            },
            //14
            new Technology
            {
                Name = "Formation Flying",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage fighters
            },
            //15
            new Technology
            {
                Name = "Force Rotation",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add Hit fighters
            },
            // Naval doctrines
            //16
            new Technology
            {
                Name = "Fleet In Being",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit esminec, kreyser and linkor
            },
            //17
            new Technology
            {
                Name = "Trade Interdiction",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit esminec and submarine
            },
            //18
            new Technology
            {
                Name = "Base Strike",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit airship and bombers
            },
            //1937
            // Civil
            //19
            new Technology
            {
                Name = "Construction II",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //20
            new Technology
            {
                Name = "Improved machine tools",
                typeTech = TypeTech.Viyskov,
                Time = 2,
                PlusArm = 2
            },
            // Country bonus
            //21
            new Technology
            {
                Name = "Radio",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 3 //stabilnisty
            },
            //Flot
            //22
            new Technology
            {
                Name = "Flot II",
                typeTech = TypeTech.Flot,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //23
            new Technology
            {
                Name = "Delay Mob War",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit pihota and motorized/mehanized
            },
            //24
            new Technology
            {
                Name = "Delay",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 3 // Add hit pihota
            },
            //25
            new Technology
            {
                Name = "Grand Battle Plan",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Zmenchenya price for polks 
            },
            //26
            new Technology
            {
                Name = "Pocket Defense",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add 5% to hit polks in kotels
            },
            // Air doctrines
            //27
            new Technology
            {
                Name = "Infrastructure Destruction",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //28
            new Technology
            {
                Name = "Dive Bombing",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airships
            },
            //29
            new Technology
            {
                Name = "Fighter Baiting",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add Hit fighters
            },
            // Naval doctrines
            //30
            new Technology
            {
                Name = "Submarine Operations",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit submarines
            },
            //31
            new Technology
            {
                Name = "Carrier Operations",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //32
            new Technology
            {
                Name = "Convoy Escorts",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit esminecs
            },
            //1938
            // Civil
            //33
            new Technology
            {
                Name = "Construction III",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //34
            new Technology
            {
                Name = "Advanced machine tools",
                typeTech = TypeTech.Viyskov,
                Time = 2,
                PlusArm = 2
            },
            // Army
            //35
            new Technology
            {
                Name = "Improved Infantry Equipment I",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 5 //Add damage garrizon, pihota and motorized/mechanized polks
            },
            // Country bonus
            //36
            new Technology
            {
                Name = "Decimetric radar",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 3 //stabilnisty
            },
            //Flot
            //37
            new Technology
            {
                Name = "Flot III",
                typeTech = TypeTech.Flot,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //38
            new Technology
            {
                Name = "Elastic Defense",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add bronya tanks and btrs
            },
            //39
            new Technology
            {
                Name = "Mobile Defense",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add bronya pihota, garrizons and motorized/mechanized
            },
            //40
            new Technology
            {
                Name = "Prepared Defense",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add bronya pihota, garrizons and motorized/mechanized
            },
            //41
            new Technology
            {
                Name = "Defense in Depth",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add 5 to hit pihota polks
            },
            // Air doctrines
            //42
            new Technology
            {
                Name = "Naval Strike Tactics",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage airships
            },
            //43
            new Technology
            {
                Name = "Direct Ground Support",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit fighters
            },
            //44
            new Technology
            {
                Name = "Low Echelon Support",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add hit fighters
            },
            // Naval doctrines
            //45
            new Technology
            {
                Name = "Convoy Escorts in Being",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit esminecs
            },
            //46
            new Technology
            {
                Name = "Capital Ship Raiders",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //47
            new Technology
            {
                Name = "Undersea Blockade",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit submarinecs
            },
            //1939
            // Civil
            //48
            new Technology
            {
                Name = "Construction IV",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //49
            new Technology
            {
                Name = "Infantry Equipment II",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 5 //Add damage garrizon, pihota polks
            },
            // Technika
            //50
            new Technology
            {
                Name = "Medium Tank I",
                typeTech = TypeTech.Technika,
                Time = 2
            },
            // Country bonus
            //51
            new Technology
            {
                Name = "Improved decimetric radar",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 5 //stabilnisty
            },
            //Flot
            //52
            new Technology
            {
                Name = "Flot IV",
                typeTech = TypeTech.Flot,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //53
            new Technology
            {
                Name = "Armored Spearhead",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage tanks
            },
            //54
            new Technology
            {
                Name = "Dispersed Support",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit artillery
            },
            //55
            new Technology
            {
                Name = "Grand Assault",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //56
            new Technology
            {
                Name = "People's Army",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add 5 to hit garrizon polks
            },
            // Air doctrines
            //57
            new Technology
            {
                Name = "Dogfighting Experience",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage fighters
            },
            //58
            new Technology
            {
                Name = "Fighter Ace Initiative",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit and damage airs
            },
            //59
            new Technology
            {
                Name = "Dispersed Fighting",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add hit fighters
            },
            // Naval doctrines
            //60
            new Technology
            {
                Name = "Convoy Interdiction",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit submarines
            },
            //61
            new Technology
            {
                Name = "Subsidiary Carrier Role",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //62
            new Technology
            {
                Name = "Floating Airfield",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //1940
            // Civil
            //63
            new Technology
            {
                Name = "Construction V",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //64
            new Technology
            {
                Name = "Improved Infantry Equipment II",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 5 //Add damage garrizon, pihota and motorized/mechanized polks
            },
            //65
            new Technology
            {
                Name = "Mechanized Equipment I",
                typeTech = TypeTech.Army,
                Time = 2
            },
            // Air
            //66
            new Technology
            {
                Name = "Fighter II and Bomber II",
                typeTech = TypeTech.Air,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Country bonus
            //67
            new Technology
            {
                Name = "Centimetric radar",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 7 //stabilnisty
            },
            //Flot
            //68
            new Technology
            {
                Name = "Flot V",
                typeTech = TypeTech.Flot,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage
            },
            // Land doctrines
            //69
            new Technology
            {
                Name = "Schwerpunkt",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit and bronya tanks
            },
            //70
            new Technology
            {
                Name = "Overwhelming Firepower",
                Time = 2,
                typeTech = TypeTech.LandDoctrine,
                PlusArm = 5 // Add damage artillery
            },
            //71
            new Technology
            {
                Name = "Mechanized Offensive",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit garrizons, pihota, motorized/mechanized polks
            },
            //72
            new Technology
            {
                Name = "Infantry Offensive",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add 5 to hit pihota polks
            },
            // Air doctrines
            //73
            new Technology
            {
                Name = "Multi-Altitude Flying",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit fighters
            },
            //74
            new Technology
            {
                Name = "Hunt and Destroy",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //75
            new Technology
            {
                Name = "Operational Destruction",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //76
            new Technology
            {
                Name = "Integrated Convoy Defense",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit kreysers
            },
            //77
            new Technology
            {
                Name = "Advanced Submarine Warfare",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit submarine
            },
            //78
            new Technology
            {
                Name = "Submarine Offensive",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit submarine
            },
            //1941
            // Civil
            //79
            new Technology
            {
                Name = "Construction VI",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskova pr
            //80
            new Technology
            {
                Name = "Assembly line production",
                typeTech = TypeTech.Viyskov,
                Time = 2,
                PlusArm = 2
            },
            // Technika
            //81
            new Technology
            {
                Name = "Light Tank II",
                typeTech = TypeTech.Technika,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage light tank
            },
            //82
            new Technology
            {
                Name = "Medium Tank II",
                typeTech = TypeTech.Technika,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage medium tank
            },
            //83
            new Technology
            {
                Name = "Heavy Tank II",
                typeTech = TypeTech.Technika,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage heavy tank
            },
            // Country bonus
            //84
            new Technology
            {
                Name = "Improved centimetric radar",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 9 //stabilnisty
            },
            // Land doctrines
            //85
            new Technology
            {
                Name = "Blitzkrieg",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            //86
            new Technology
            {
                Name = "Mechanized Offensive I",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add bronya tanks
            },
            //87
            new Technology
            {
                Name = "Assault Concentration",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //88
            new Technology
            {
                Name = "Large Front Offensive",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit pihota polks
            },
            // Air doctrines
            //89
            new Technology
            {
                Name = "Logistical Bombing",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //90
            new Technology
            {
                Name = "Combat Unit Destruction",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //91
            new Technology
            {
                Name = "Ground Attack Veteran Initiative",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //92
            new Technology
            {
                Name = "Floating Airfield",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit airships
            },
            //93
            new Technology
            {
                Name = "Combined Operations Raiding",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit flots
            },
            //94
            new Technology
            {
                Name = "Floating Fortress",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //1942
            // Civil
            //95
            new Technology
            {
                Name = "Construction VII",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //96
            new Technology
            {
                Name = "Infantry Anti-Tank I",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks protu techniks
            },
            //97
            new Technology
            {
                Name = "Mechanized Equipment II",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 10 // Add Hit and Damage mehanized polks
            },
            // Country bonus
            //98
            new Technology
            {
                Name = "Advanced centimetric radar",
                typeTech = TypeTech.Country,
                Time = 2,
                PlusCount = 11 //stabilnisty
            },
            // Land doctrines
            //99
            new Technology
            {
                Name = "Kampfgruppe",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 10 // Add hit pohotas polks
            },
            //100
            new Technology
            {
                Name = "Centralized Fire Control",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage artillery and pihotas polks
            },
            //101
            new Technology
            {
                Name = "Branch Inter-Operation",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage pihotas and tanks polks
            },
            //102
            new Technology
            {
                Name = "Human Wave Offensive",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit pihota polks
            },
            // Air doctrines
            //103
            new Technology
            {
                Name = "Night Bombing",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //104
            new Technology
            {
                Name = "Battlefield Support",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //105
            new Technology
            {
                Name = "Carousel Bombing",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add damage bombers
            },
            // Naval doctrines
            //106
            new Technology
            {
                Name = "Grand Battlefleet",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors
            },
            //107
            new Technology
            {
                Name = "Carrier Battlegroups",
                typeTech = TypeTech.FlotDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage and hit linkors and esminecs and kreysers
            },
            //1943
            // Civil
            //108
            new Technology
            {
                Name = "Construction VIII",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Viyskov prom
            //109
            new Technology
            {
                Name = "Flexible line",
                typeTech = TypeTech.Viyskov,
                Time = 2,
                PlusArm = 10 // viyskovPromka
            },
            // Army
            //110
            new Technology
            {
                Name = "Night Vision I",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks protu pihotas
            },
            // Land doctrines
            //111
            new Technology
            {
                Name = "Volkssturm",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 10 // Add % viyskova obovyazane
            },
            //112
            new Technology
            {
                Name = "Forward Observers",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit artillery
            },
            //113
            new Technology
            {
                Name = "Central Planning",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //114
            new Technology
            {
                Name = "Guerrilla Warfare",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            // Air doctrines
            //115
            new Technology
            {
                Name = "Massed Bomber Formations",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add damage bombers
            },
            //116
            new Technology
            {
                Name = "Naval Strike Torpedo Tactics",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airships
            },
            //117
            new Technology
            {
                Name = "Infiltration Bombing",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 8 // Add hit bombers
            },
            //1944
            // Civil
            //118
            new Technology
            {
                Name = "Construction IX",
                typeTech = TypeTech.Civil,
                Time = 2,
                PlusCiv = 10 // civilPromka
            },
            // Army
            //119
            new Technology
            {
                Name = "Infantry Equipment III",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 10 // Add Damage pihotas polks
            },
            //120
            new Technology
            {
                Name = "Mechanized Equipment III",
                typeTech = TypeTech.Army,
                Time = 2,
                PlusArm = 10 // Add Damage mechanized polks
            },
            // Land doctrines
            //121
            new Technology
            {
                Name = "Non-Discriminatory Conscription",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 10 // Add % viyskova obovyazane
            },
            //122
            new Technology
            {
                Name = "Advanced Firebases",
                Time = 2,
                typeTech = TypeTech.LandDoctrine,
                PlusArm = 5 // Add bronya artillery
            },
            //123
            new Technology
            {
                Name = "C3I",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 7 // Add hit polks
            },
            //124
            new Technology
            {
                Name = "Guerrilla Warfare",
                typeTech = TypeTech.LandDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit polks
            },
            // Air doctrines
            //125
            new Technology
            {
                Name = "Flying Fortress",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 5 // Add hit bombers
            },
            //126
            new Technology
            {
                Name = "Strategic Destruction",
                typeTech = TypeTech.AirDoctrine,
                Time = 2,
                PlusArm = 7 // Add damage airs
            },
            //127
            new Technology
            {
                Name = "Air Skirmish",
                typeTech = TypeTech.AirDoctrine,
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
                Name = "Gannover",
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
                Name = "Shtugart",
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
                Name = "Kiev",
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
                Population = 15456
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
                Population = 15456
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
                Population = 15456
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
                Population = 15456
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
                Population = 15456
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
                Population = 15456
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
                Population = 17945
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
                Population = 17945
            },
            //Portugal
            //122
            new Region()
            {
                Name = "Lisabon",
                town = towns[122],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //123
            new Region()
            {
                Name = "Porto",
                town = towns[123],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Spain
            //124
            new Region()
            {
                Name = "Madrid",
                town = towns[124],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //125
            new Region()
            {
                Name = "Barselona",
                town = towns[125],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //126
            new Region()
            {
                Name = "Saragoza",
                town = towns[126],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //127
            new Region()
            {
                Name = "Bilbao",
                town = towns[127],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //128
            new Region()
            {
                Name = "La-Korunya",
                town = towns[128],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //129
            new Region()
            {
                Name = "Valencia",
                town = towns[129],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //130
            new Region()
            {
                Name = "Murcia",
                town = towns[130],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //131
            new Region()
            {
                Name = "Malaga",
                town = towns[131],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //132
            new Region()
            {
                Name = "Sevilya",
                town = towns[132],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //133
            new Region()
            {
                Name = "Palma",
                town = towns[133],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Irland
            //134
            new Region()
            {
                Name = "Dublin",
                town = towns[134],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //135
            new Region()
            {
                Name = "Galuley",
                town = towns[135],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //136
            new Region()
            {
                Name = "Kork",
                town = towns[136],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Britain
            //137
            new Region()
            {
                Name = "London",
                town = towns[137],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //138
            new Region()
            {
                Name = "Plimut",
                town = towns[138],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //139
            new Region()
            {
                Name = "Birnigem",
                town = towns[139],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //140
            new Region()
            {
                Name = "Manchester",
                town = towns[140],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //141
            new Region()
            {
                Name = "Edinburg",
                town = towns[141],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //142
            new Region()
            {
                Name = "Invernes",
                town = towns[142],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //143
            new Region()
            {
                Name = "Belfast",
                town = towns[143],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //144
            new Region()
            {
                Name = "Gibraltar",
                town = towns[144],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //145
            new Region()
            {
                Name = "Kembrudg",
                town = towns[145],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Netarland
            //146
            new Region()
            {
                Name = "Amsterdam",
                town = towns[146],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //147
            new Region()
            {
                Name = "Groningem",
                town = towns[147],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Belgiya
            //148
            new Region()
            {
                Name = "Brussel",
                town = towns[148],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Chechoslovakia
            //149
            new Region()
            {
                Name = "Praga",
                town = towns[149],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //150
            new Region()
            {
                Name = "Brno",
                town = towns[150],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //151
            new Region()
            {
                Name = "Kochuce",
                town = towns[151],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Austria
            //152
            new Region()
            {
                Name = "Vienna",
                town = towns[152],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //153
            new Region()
            {
                Name = "Insbruck",
                town = towns[153],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Swethariya
            //154
            new Region()
            {
                Name = "Curich",
                town = towns[154],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //155
            new Region()
            {
                Name = "Bern",
                town = towns[155],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Italy
            //156
            new Region()
            {
                Name = "Rome",
                town = towns[156],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //157
            new Region()
            {
                Name = "Neapol",
                town = towns[157],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //158
            new Region()
            {
                Name = "Palermo",
                town = towns[158],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //159
            new Region()
            {
                Name = "Kataniya",
                town = towns[159],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //160
            new Region()
            {
                Name = "Bari",
                town = towns[160],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //161
            new Region()
            {
                Name = "San-Marino",
                town = towns[161],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //162
            new Region()
            {
                Name = "Florancya",
                town = towns[162],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //163
            new Region()
            {
                Name = "Bolonya",
                town = towns[163],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //164
            new Region()
            {
                Name = "Venecia",
                town = towns[164],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //165
            new Region()
            {
                Name = "Milan",
                town = towns[165],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //166
            new Region()
            {
                Name = "Genya",
                town = towns[166],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //167
            new Region()
            {
                Name = "Sardunya",
                town = towns[167],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //France
            //168
            new Region()
            {
                Name = "Paris",
                town = towns[168],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //169
            new Region()
            {
                Name = "Lil",
                town = towns[169],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //170
            new Region()
            {
                Name = "Strasburg",
                town = towns[170],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //171
            new Region()
            {
                Name = "Kan",
                town = towns[171],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //172
            new Region()
            {
                Name = "Nant",
                town = towns[172],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //173
            new Region()
            {
                Name = "Lion",
                town = towns[173],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //174
            new Region()
            {
                Name = "Tulusa",
                town = towns[174],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //175
            new Region()
            {
                Name = "Marsel",
                town = towns[175],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //176
            new Region()
            {
                Name = "Monpelye",
                town = towns[176],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //177
            new Region()
            {
                Name = "Corsica",
                town = towns[177],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //178
            new Region()
            {
                Name = "Alchur",
                town = towns[178],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //179
            new Region()
            {
                Name = "Tunnis",
                town = towns[179],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //180
            new Region()
            {
                Name = "Klermon-Farmon",
                town = towns[180],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            },
            //Luxemburg
            //181
            new Region()
            {
                Name = "Luxemburg",
                town = towns[181],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 17945
            },
            //Dancig
            //182
            new Region()
            {
                Name = "Dancig",
                town = towns[182],
                divisions = new List<Division>(),
                builds = new List<Build>()
                {
                    BuildList[0]
                },
                Population = 24592
            }
        };
        CountryList = new List<Country>()
        {
            //0
            new Country()
            {
                Name = "Third Reich",
                idelogy = Idelogies.Fascism,
                Popularity = 60,
                Flag = flags[0]
            },
            //1
            new Country()
            {
                Name = "Soborna Ukraine",
                idelogy = Idelogies.Nationalism,
                Popularity = 60,
                Flag = flags[1]
            },
            //2
            new Country()
            {
                Name = "Albania",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[2]
            },
            //3
            new Country()
            {
                Name = "Grecia",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[3]
            },
            //4
            new Country()
            {
                Name = "Turcia",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[4]
            },
            //5
            new Country()
            {
                Name = "Bolgaria",
                idelogy = Idelogies.Monarchy,
                Popularity = 60,
                Flag = flags[5]
            },
            //6
            new Country()
            {
                Name = "Yugoslavia",
                idelogy = Idelogies.Monarchy,
                Popularity = 60,
                Flag = flags[6]
            },
            //7
            new Country()
            {
                Name = "Rumunia",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[7]
            },
            //8
            new Country()
            {
                Name = "sssr",
                idelogy = Idelogies.Communism,
                Popularity = 60,
                Flag = flags[8]
            },
            //9
            new Country()
            {
                Name = "Poland",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[9]
            },
            //10
            new Country()
            {
                Name = "Hungary",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[10]
            },
            //11
            new Country()
            {
                Name = "Lutva",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[11]
            },
            //12
            new Country()
            {
                Name = "Latvia",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[12]
            },
            //13
            new Country()
            {
                Name = "Estonia",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[13]
            },
            //14
            new Country()
            {
                Name = "Norway",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[14]
            },
            //15
            new Country()
            {
                Name = "Sweden",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[15]
            },
            //16
            new Country()
            {
                Name = "Daniya",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[16]
            },
            //17
            new Country()
            {
                Name = "Portugal",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[17]
            },
            //18
            new Country()
            {
                Name = "Spain",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[18]
            },
            //19
            new Country()
            {
                Name = "Irland",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[19]
            },
            //20
            new Country()
            {
                Name = "Britain",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[20]
            },
            //21
            new Country()
            {
                Name = "Netharland",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[21]
            },
            //22
            new Country()
            {
                Name = "Belgue",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[22]
            },
            //23
            new Country()
            {
                Name = "Chehoslovakia",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[23]
            },
            //24
            new Country()
            {
                Name = "Austria",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[24]
            },
            //25
            new Country()
            {
                Name = "Swithland",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[25]
            },
            //26
            new Country()
            {
                Name = "Italy",
                idelogy = Idelogies.Fascism,
                Popularity = 60,
                Flag = flags[26]
            },
            //27
            new Country()
            {
                Name = "France",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[27]
            },
            //28
            new Country()
            {
                Name = "Luxemburg",
                idelogy = Idelogies.Democraty,
                Popularity = 60,
                Flag = flags[28]
            },
            //29
            new Country()
            {
                Name = "Dancig",
                idelogy = Idelogies.Neutrall,
                Popularity = 60,
                Flag = flags[29]
            }
        };
        liderList = new List<Lider>()
        {
            //Ukraine
            //0
            new Lider()
            {
                Name = "Stepan Bandera",
                idelogies = Idelogies.Nationalism,
                country = CountryList[1],
                foto = fotos[0]
            },
            //1
            new Lider()
            {
                Name = "Andriy Melnik",
                idelogies = Idelogies.Fascism,
                country = CountryList[1],
                foto = fotos[1]
            },
            //2
            new Lider()
            {
                Name = "Simon Petlura",
                idelogies = Idelogies.Democraty,
                country = CountryList[1],
                foto = fotos[2]
            },
            //3
            new Lider()
            {
                Name = "Volodymur Vynychenko",
                idelogies = Idelogies.Communism,
                country = CountryList[1],
                foto = fotos[3]
            },
            //4
            new Lider()
            {
                Name = "Pavlo Skoropadskiy",
                idelogies = Idelogies.Monarchy,
                country = CountryList[1],
                foto = fotos[4]
            },
            //5
            new Lider()
            {
                Name = "Nestor Mahno",
                idelogies = Idelogies.Anarchy,
                country = CountryList[1],
                foto = fotos[5]
            },
            //Poland
            //6
            new Lider()
            {
                Name = "Yozef Pilsudskiy",
                idelogies = Idelogies.Neutrall,
                country = CountryList[9],
                foto = fotos[6]
            },
            //7
            new Lider()
            {
                Name = "Vincentiy Vitoc",
                idelogies = Idelogies.Democraty,
                country = CountryList[9],
                foto = fotos[7]
            },
            //8
            new Lider()
            {
                Name = "Vladyslav Gomulka",
                idelogies = Idelogies.Communism,
                country = CountryList[9],
                foto = fotos[8]
            },
            //9
            new Lider()
            {
                Name = "Karl Albreht I",
                idelogies = Idelogies.Monarchy,
                country = CountryList[9],
                foto = fotos[9]
            },
            //10
            new Lider()
            {
                Name = "Boleslav Pyaseckiy",
                idelogies = Idelogies.Fascism,
                country = CountryList[9],
                foto = fotos[10]
            },
            //Rumunia
            //11
            new Lider()
            {
                Name = "George Tataresku",
                idelogies = Idelogies.Democraty,
                country = CountryList[7],
                foto = fotos[11]
            },
            //12
            new Lider()
            {
                Name = "Konstyantun Ion Parhon",
                idelogies = Idelogies.Communism,
                country = CountryList[7],
                foto = fotos[12]
            },
            //13
            new Lider()
            {
                Name = "Karl II",
                idelogies = Idelogies.Monarchy,
                country = CountryList[7],
                foto = fotos[13]
            },
            //14
            new Lider()
            {
                Name = "Oktavia Goga",
                idelogies = Idelogies.Fascism,
                country = CountryList[7],
                foto = fotos[14]
            },
            //sssr
            //15
            new Lider()
            {
                Name = "yosef stalin",
                idelogies = Idelogies.Communism,
                country = CountryList[8],
                foto = fotos[15]
            },
            //16
            new Lider()
            {
                Name = "lev trockiy",
                idelogies = Idelogies.ViyskovuyCummunism,
                country = CountryList[8],
                foto = fotos[16]
            },
            //17
            new Lider()
            {
                Name = "romanov V",
                idelogies = Idelogies.Monarchy,
                country = CountryList[8],
                foto = fotos[17]
            },
            //18
            new Lider()
            {
                Name = "konstyantun rodsayevskiy",
                idelogies = Idelogies.Fascism,
                country = CountryList[8],
                foto = fotos[18]
            },
            // Germany
            //19
            new Lider()
            {
                Name = "Adolf Hitler",
                idelogies = Idelogies.Fascism,
                country = CountryList[0],
                foto = fotos[19]
            },
            //20
            new Lider()
            {
                Name = "Konrad Adenaur",
                idelogies = Idelogies.Democraty,
                country = CountryList[0],
                foto = fotos[20]
            },
            //21
            new Lider()
            {
                Name = "Vilgelm Pik",
                idelogies = Idelogies.Communism,
                country = CountryList[0],
                foto = fotos[21]
            },
            //22
            new Lider()
            {
                Name = "Vilgelm II",
                idelogies = Idelogies.Monarchy,
                country = CountryList[0],
                foto = fotos[22]
            }
        };

        InitilizerCountry();

        // Initilization BasicTechnology
        if (CountryList[0].techs != null)
        {
            TechnologyList[0].builds.Add(BuildList[0]);
            TechnologyList[0].builds.Add(BuildList[2]);
            TechnologyList[0].builds.Add(BuildList[3]);
            TechnologyList[0].builds.Add(BuildList[4]);
            TechnologyList[0].builds.Add(BuildList[5]);
            TechnologyList[0].builds.Add(BuildList[6]);
            TechnologyList[0].builds.Add(BuildList[7]);
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

        //Initilize lider
        for (int i = 0; i < liderList.Count; i++)
        {
            for (int j = 0; j < CountryList.Count; j++)
            {
                if (liderList[i].country.Name == CountryList[j].Name)
                {
                    if (liderList[i].idelogies == CountryList[j].idelogy)
                    {
                        CountryList[j].currentLider = liderList[i];
                    }
                }
            }
        }
    }

    public void InitilizerCountry()
    {

        //Initilize country
        if (CountryList[0].regions != null)
        {
            //0
            CountryList[0].regions.Add(RegionList[0]);
            CountryList[0].regions.Add(RegionList[1]);
            CountryList[0].regions.Add(RegionList[2]);
            CountryList[0].regions.Add(RegionList[3]);
            CountryList[0].regions.Add(RegionList[4]);
            CountryList[0].regions.Add(RegionList[5]);
            CountryList[0].regions.Add(RegionList[6]);
            CountryList[0].regions.Add(RegionList[7]);
            CountryList[0].regions.Add(RegionList[8]);
            CountryList[0].regions.Add(RegionList[9]);
            CountryList[0].regions.Add(RegionList[10]);
            CountryList[0].regions.Add(RegionList[11]);
            CountryList[0].regions.Add(RegionList[12]);
            CountryList[0].regions.Add(RegionList[13]);
            CountryList[0].regions.Add(RegionList[14]);
            CountryList[0].regions.Add(RegionList[15]);
            //1
            CountryList[1].regions.Add(RegionList[16]);
            CountryList[1].regions.Add(RegionList[17]);
            CountryList[1].regions.Add(RegionList[18]);
            CountryList[1].regions.Add(RegionList[19]);
            CountryList[1].regions.Add(RegionList[20]);
            CountryList[1].regions.Add(RegionList[22]);
            CountryList[1].regions.Add(RegionList[23]);
            CountryList[1].regions.Add(RegionList[24]);
            CountryList[1].regions.Add(RegionList[25]);
            CountryList[1].regions.Add(RegionList[26]);
            CountryList[1].regions.Add(RegionList[27]);
            CountryList[1].regions.Add(RegionList[28]);
            CountryList[1].regions.Add(RegionList[29]);
            CountryList[1].regions.Add(RegionList[30]);
            CountryList[1].regions.Add(RegionList[31]);
            CountryList[1].regions.Add(RegionList[32]);
            CountryList[1].regions.Add(RegionList[33]);
            CountryList[1].regions.Add(RegionList[34]);
            CountryList[1].regions.Add(RegionList[35]);
            CountryList[1].regions.Add(RegionList[36]);
            CountryList[1].regions.Add(RegionList[37]);
            CountryList[1].regions.Add(RegionList[38]);
            CountryList[1].regions.Add(RegionList[39]);
            CountryList[1].regions.Add(RegionList[40]);
            CountryList[1].regions.Add(RegionList[41]);
            CountryList[1].regions.Add(RegionList[42]);
            CountryList[1].regions.Add(RegionList[43]);
            CountryList[1].regions.Add(RegionList[44]);
            CountryList[1].regions.Add(RegionList[45]);
            CountryList[1].regions.Add(RegionList[46]);
            CountryList[1].regions.Add(RegionList[47]);
            CountryList[1].regions.Add(RegionList[48]);
            CountryList[1].regions.Add(RegionList[49]);
            CountryList[1].regions.Add(RegionList[50]);
            //2
            CountryList[2].regions.Add(RegionList[51]);
            //3
            CountryList[3].regions.Add(RegionList[52]);
            CountryList[3].regions.Add(RegionList[53]);
            CountryList[3].regions.Add(RegionList[54]);
            CountryList[3].regions.Add(RegionList[55]);
            //4
            CountryList[4].regions.Add(RegionList[56]);
            CountryList[4].regions.Add(RegionList[57]);
            CountryList[4].regions.Add(RegionList[58]);
            CountryList[4].regions.Add(RegionList[59]);
            CountryList[4].regions.Add(RegionList[60]);
            CountryList[4].regions.Add(RegionList[61]);
            CountryList[4].regions.Add(RegionList[62]);
            CountryList[4].regions.Add(RegionList[63]);
            CountryList[4].regions.Add(RegionList[64]);
            CountryList[4].regions.Add(RegionList[65]);
            CountryList[4].regions.Add(RegionList[66]);
            CountryList[4].regions.Add(RegionList[67]);
            CountryList[4].regions.Add(RegionList[68]);
            //5
            CountryList[5].regions.Add(RegionList[69]);
            CountryList[5].regions.Add(RegionList[70]);
            CountryList[5].regions.Add(RegionList[71]);
            //6
            CountryList[6].regions.Add(RegionList[72]);
            CountryList[6].regions.Add(RegionList[73]);
            CountryList[6].regions.Add(RegionList[74]);
            CountryList[6].regions.Add(RegionList[75]);
            CountryList[6].regions.Add(RegionList[76]);
            CountryList[6].regions.Add(RegionList[77]);
            CountryList[6].regions.Add(RegionList[78]);
            //7
            CountryList[7].regions.Add(RegionList[79]);
            CountryList[7].regions.Add(RegionList[80]);
            CountryList[7].regions.Add(RegionList[81]);
            CountryList[7].regions.Add(RegionList[82]);
            CountryList[7].regions.Add(RegionList[83]);
            CountryList[7].regions.Add(RegionList[84]);
            //8
            CountryList[8].regions.Add(RegionList[85]);
            CountryList[8].regions.Add(RegionList[86]);
            CountryList[8].regions.Add(RegionList[87]);
            CountryList[8].regions.Add(RegionList[88]);
            CountryList[8].regions.Add(RegionList[89]);
            CountryList[8].regions.Add(RegionList[90]);
            CountryList[8].regions.Add(RegionList[91]);
            CountryList[8].regions.Add(RegionList[92]);
            CountryList[8].regions.Add(RegionList[93]);
            CountryList[8].regions.Add(RegionList[94]);
            CountryList[8].regions.Add(RegionList[94]);
            CountryList[8].regions.Add(RegionList[96]);
            CountryList[8].regions.Add(RegionList[97]);
            CountryList[8].regions.Add(RegionList[98]);
            //9
            CountryList[9].regions.Add(RegionList[99]);
            CountryList[9].regions.Add(RegionList[100]);
            CountryList[9].regions.Add(RegionList[101]);
            CountryList[9].regions.Add(RegionList[102]);
            CountryList[9].regions.Add(RegionList[103]);
            CountryList[9].regions.Add(RegionList[104]);
            CountryList[9].regions.Add(RegionList[105]);
            CountryList[9].regions.Add(RegionList[106]);
            //10
            CountryList[10].regions.Add(RegionList[107]);
            CountryList[10].regions.Add(RegionList[108]);
            //11
            CountryList[11].regions.Add(RegionList[109]);
            CountryList[11].regions.Add(RegionList[110]);
            //12
            CountryList[12].regions.Add(RegionList[111]);
            CountryList[12].regions.Add(RegionList[112]);
            //13
            CountryList[13].regions.Add(RegionList[113]);
            CountryList[13].regions.Add(RegionList[114]);
            //14
            CountryList[14].regions.Add(RegionList[115]);
            CountryList[14].regions.Add(RegionList[116]);
            //15
            CountryList[15].regions.Add(RegionList[117]);
            CountryList[15].regions.Add(RegionList[118]);
            CountryList[15].regions.Add(RegionList[119]);
            //16
            CountryList[16].regions.Add(RegionList[120]);
            CountryList[16].regions.Add(RegionList[121]);
            //17
            CountryList[17].regions.Add(RegionList[122]);
            CountryList[17].regions.Add(RegionList[123]);
            //18
            CountryList[18].regions.Add(RegionList[124]);
            CountryList[18].regions.Add(RegionList[125]);
            CountryList[18].regions.Add(RegionList[126]);
            CountryList[18].regions.Add(RegionList[127]);
            CountryList[18].regions.Add(RegionList[128]);
            CountryList[18].regions.Add(RegionList[129]);
            CountryList[18].regions.Add(RegionList[130]);
            CountryList[18].regions.Add(RegionList[131]);
            CountryList[18].regions.Add(RegionList[132]);
            CountryList[18].regions.Add(RegionList[133]);
            //19
            CountryList[19].regions.Add(RegionList[134]);
            CountryList[19].regions.Add(RegionList[135]);
            CountryList[19].regions.Add(RegionList[136]);
            //20
            CountryList[20].regions.Add(RegionList[137]);
            CountryList[20].regions.Add(RegionList[138]);
            CountryList[20].regions.Add(RegionList[139]);
            CountryList[20].regions.Add(RegionList[140]);
            CountryList[20].regions.Add(RegionList[141]);
            CountryList[20].regions.Add(RegionList[142]);
            CountryList[20].regions.Add(RegionList[143]);
            CountryList[20].regions.Add(RegionList[144]);
            CountryList[20].regions.Add(RegionList[145]);
            //21
            CountryList[21].regions.Add(RegionList[146]);
            CountryList[21].regions.Add(RegionList[147]);
            //22
            CountryList[22].regions.Add(RegionList[148]);
            //23
            CountryList[23].regions.Add(RegionList[149]);
            CountryList[23].regions.Add(RegionList[150]);
            CountryList[23].regions.Add(RegionList[151]);
            //24
            CountryList[24].regions.Add(RegionList[152]);
            CountryList[24].regions.Add(RegionList[153]);
            //25
            CountryList[25].regions.Add(RegionList[154]);
            CountryList[25].regions.Add(RegionList[155]);
            //26
            CountryList[26].regions.Add(RegionList[156]);
            CountryList[26].regions.Add(RegionList[157]);
            CountryList[26].regions.Add(RegionList[158]);
            CountryList[26].regions.Add(RegionList[159]);
            CountryList[26].regions.Add(RegionList[160]);
            CountryList[26].regions.Add(RegionList[161]);
            CountryList[26].regions.Add(RegionList[162]);
            CountryList[26].regions.Add(RegionList[163]);
            CountryList[26].regions.Add(RegionList[164]);
            CountryList[26].regions.Add(RegionList[165]);
            CountryList[26].regions.Add(RegionList[166]);
            CountryList[26].regions.Add(RegionList[167]);
            //27
            CountryList[27].regions.Add(RegionList[168]);
            CountryList[27].regions.Add(RegionList[169]);
            CountryList[27].regions.Add(RegionList[170]);
            CountryList[27].regions.Add(RegionList[171]);
            CountryList[27].regions.Add(RegionList[172]);
            CountryList[27].regions.Add(RegionList[173]);
            CountryList[27].regions.Add(RegionList[174]);
            CountryList[27].regions.Add(RegionList[175]);
            CountryList[27].regions.Add(RegionList[176]);
            CountryList[27].regions.Add(RegionList[177]);
            CountryList[27].regions.Add(RegionList[178]);
            CountryList[27].regions.Add(RegionList[179]);
            CountryList[27].regions.Add(RegionList[180]);
            //28
            CountryList[28].regions.Add(RegionList[181]);
            //29
            CountryList[29].regions.Add(RegionList[182]);
        }

        for (int i = 0; i < CountryList.Count; i++)
        {
            CountryList[i].Stabilnisty = 50 + (100 / CountryList[i].Popularity);
            if (CountryList[i].regions != null)
            {
                for (int j = 0; j < CountryList[i].regions.Count; j++)
                {
                    CountryList[i].PopulationCount += CountryList[i].regions[j].Population;
                    for (int a = 0; a < CountryList[i].regions[j].divisions.Count; a++)
                    {
                        if (CountryList[i].regions[j].divisions.Count > 0)
                        {
                            kilkNayn += CountryList[i].regions[j].divisions[a].polks.Count * 100;
                        }
                        else
                        {
                            Debug.Log("Not division");
                        }
                    }
                }
            }
            else
            {
                Debug.Log("Not regions");
            }
            CountryList[i].ProcentViyskovoZob = 10;
            CountryList[i].KilkistyRecruit = CountryList[i].PopulationCount / (100 / CountryList[i].ProcentViyskovoZob) - kilkNayn;
            CountryList[i].Money = 5000;
            CountryList[i].BuildResourse = 5000;
            CountryList[i].Stail = 2500;
            CountryList[i].Topluvo = 1000;
            CountryList[i].Kauchuk = 1000;
            if (CountryList[i].techs != null)
            {
                CountryList[i].techs.Add(TechnologyList[0]);
            }
            else
            {
                Debug.Log("Not tech");
            }
        }

    }


}
