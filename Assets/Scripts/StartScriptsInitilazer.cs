using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScriptsInitilazer : MonoBehaviour
{
    public List<Country> CountryList = new List<Country>();
    public List<Division> DivisionList = new List<Division>();

    public void Start()
    {
        int sumSteps = 0;
        int kilkPols = 0;

        for (int i = 0; i < CountryList.Count; i++)
        {
            CountryList[i].Stabilnisty = 50 + (100 / CountryList[i].Popularity);
            for (int j = 0; j < CountryList[i].regions.Count; j++)
            {
                CountryList[i].PopulationCount += CountryList[i].regions[j].Population;
            }
            CountryList[i].ProcentViyskovoZob = 10;
            CountryList[i].KilkistyRecruit = CountryList[i].PopulationCount * (100 / CountryList[i].ProcentViyskovoZob);
            CountryList[i].Money = 10000;
            CountryList[i].BuildResourse = 5000;
            CountryList[i].Stail = 2500;
            CountryList[i].Topluvo = 1000;
            CountryList[i].Kauchuk = 1000;
        }

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

    public void Update()
    {
        
    }

}
