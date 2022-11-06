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
            new Technology
            {
                Name = "Basic technology",
                Time = 0
            }
        };

        // Initilization BasicTechnology
        TechnologyList[0].builds.Add(BuildList[0]);
        TechnologyList[0].polks.Add(PolkList[0]);
        TechnologyList[0].polks.Add(PolkList[1]);
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
            CountryList[i].Money = 10000;
            CountryList[i].BuildResourse = 5000;
            CountryList[i].Stail = 2500;
            CountryList[i].Topluvo = 1000;
            CountryList[i].Kauchuk = 1000;
            CountryList[i].techs.Add(TechnologyList[0]);
        }
    }


}
