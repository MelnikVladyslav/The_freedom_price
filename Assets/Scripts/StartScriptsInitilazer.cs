using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScriptsInitilazer : MonoBehaviour
{
    public List<Country> CountryList = new List<Country>();
    public List<Division> DivisionList = new List<Division>();
    public List<Technology> TechnologyList = new List<Technology>();
    public List<Polk> PolkList = new List<Polk>();
    public List<Build> BuildList = new List<Build>();

    public void Start()
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

        InitilizerTechnology();
    }

    void InitilizerTechnology()
    {
        // Initilization Basic technology
        TechnologyList[0].polks.Add(PolkList[0]);
        TechnologyList[0].polks.Add(PolkList[1]);
        TechnologyList[0].builds.Add(BuildList[0]);

    }

    public void Update()
    {
        int sumSteps = 0;
        int kilkPols = 0;
        if (DivisionList.Count > 0)
        {
            for (int i = 0; i < DivisionList.Count; i++)
            {
                for (int j = 0; j < DivisionList[i].polks.Count; j++)
                {
                    sumSteps += DivisionList[i].polks[j].Step;
                    kilkPols++;
                    DivisionList[i].Price += DivisionList[i].polks[j].Price;
                }
                DivisionList[i].ZagStep = sumSteps / kilkPols;
            }
        }

    }

}
