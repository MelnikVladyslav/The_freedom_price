using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class NavigationDown : MonoBehaviour
    {
        public StartScriptsInitilazer start;
        public RawImage Flag;
        public Text Builds;
        public Text Info;
        public Text NameReg;
        int idCountry = 0;
        int idRegion = 0;
        int kilkCivil = 0;
        int kilkBig = 0;
        int kilkDef = 0;

        public void EnterTown(string name)
        {
            kilkCivil = 0;
            kilkBig = 0;
            kilkDef = 0;

            if (start.CountryList[0].regions != null)
            {
                for (int i = 0; i < start.CountryList.Count; i++)
                {
                    for (int j = 0; j < start.CountryList[i].regions.Count; j++)
                    {
                        if (start.CountryList[i].regions[j].Name == name)
                        {
                            idCountry = i;
                            idRegion = j;

                            for (int a = 0; a < start.CountryList[i].regions[j].builds.Count; a++)
                            {
                                if (start.CountryList[i].regions[j].builds[a].Type == TypeBuild.Lehka)
                                {
                                    kilkCivil++;
                                }
                                else if (start.CountryList[i].regions[j].builds[a].Type == TypeBuild.Big)
                                {
                                    kilkBig++;
                                }
                                else if (start.CountryList[i].regions[j].builds[a].Type == TypeBuild.Defend)
                                {
                                    kilkDef++;
                                }
                            }
                        }
                    }
                }

                Flag.texture = start.CountryList[idCountry].Flag;
                Builds.text = "Civil promuslovisty: " + kilkCivil + "\nArmy promuslovisty: " + kilkBig + "\nDefend builds: " + kilkDef;
                Info.text = "Population: " + start.CountryList[idCountry].regions[idRegion].Population + "\nKilkisty Divisions: " + start.CountryList[idCountry].regions[idRegion].divisions.Count;
                NameReg.text = start.CountryList[idCountry].regions[idRegion].Name;

            }

        }
    }
}