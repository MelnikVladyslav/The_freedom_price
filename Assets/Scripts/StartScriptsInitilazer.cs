using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScriptsInitilazer : MonoBehaviour
{
    List<Country> CountryList;
    List<Division> DivisionList = new List<Division>();
    List<Technology> TechnologyList;
    List<Polk> PolkList;
    List<Build> BuildList;
    List<Air> AirList;
    List<Flot> FlotList;
    List<Region> RegionList;
    List<Flotiliya> FlotiliyaList = new List<Flotiliya>();

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
                PlusArm = 5 // Add damage Garrizon and Pihota polks
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

        // Initilization technology 1936
        TechnologyList[1].builds.Add(BuildList[1]);
        TechnologyList[5].polks.Add(PolkList[4]);
        TechnologyList[6].polks.Add(PolkList[6]);
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
