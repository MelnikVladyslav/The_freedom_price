using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class SkipTurn : MonoBehaviour
    {
        public EnterNation enterNation;
        public CountryMechanics countryMechanics;
        public TechnologyMechanic technologyMechanic;
        public StartScriptsInitilazer start;
        public Text textTime;
        public DateTime Time;
        int day = 1;
        int mounth = 1;
        int year = 1936;
        int dohid = 0;
        int dohidStail = 0;
        int dohidOil = 0;
        int dohidPod = 0;
        int kilkHodRich = 5;
        public int idTech = 0;
        public Technology currentTech;

        // Use this for initialization
        void Start()
        {
            Time = new DateTime(year, mounth, day);
            textTime.text = Time.ToString();
            for (int i = 0; i < enterNation.countryPlayer.techs.Count; i++)
            {
                if (enterNation.countryPlayer.techs[i].polks != null)
                {
                    for (int j = 0; j < enterNation.countryPlayer.techs[i].polks.Count; j++)
                    {
                        enterNation.countryPlayer.openPolks.Add(enterNation.countryPlayer.techs[i].polks[j]);
                    }
                }
                else if (enterNation.countryPlayer.techs[i].builds != null)
                {
                    for (int j = 0; j < enterNation.countryPlayer.techs[i].builds.Count; j++)
                    {
                        enterNation.countryPlayer.openBuilds.Add(enterNation.countryPlayer.techs[i].builds[j]);
                    }
                }
            }
        }

        public void NextTurn()
        {
            day += 16;

            if (day >= 30)
            {
                day -= 30;
                mounth++;
            }
            else if(mounth >= 12)
            {
                mounth = 1;
                year++;
            }

            Time = new DateTime(year, mounth, day);
            textTime.text = Time.ToString();

            dohid = 0;
            dohidPod = (enterNation.countryPlayer.PopulationCount / 100) * (100 / countryMechanics.procPod);
            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                for (int j = 0; j < enterNation.countryPlayer.regions[i].builds.Count; j++)
                {
                    if (enterNation.countryPlayer.regions[i].builds[j].Type == TypeBuild.Lehka)
                    {
                        dohid += enterNation.countryPlayer.regions[i].builds[j].Dohid;
                    }
                    if (enterNation.countryPlayer.regions[i].builds[j].Type == TypeBuild.Lehka && enterNation.countryPlayer.regions[i].builds[j].Name == "Civilian promuslovisty")
                    {
                        dohidStail += enterNation.countryPlayer.regions[i].builds[j].Dohid;
                    }
                    if (enterNation.countryPlayer.regions[i].builds[j].Type == TypeBuild.Lehka && enterNation.countryPlayer.regions[i].builds[j].Name == "Oil refinery")
                    {
                        dohidOil += enterNation.countryPlayer.regions[i].builds[j].Dohid;
                    }
                }
            }

            enterNation.countryPlayer.PopulationCount += enterNation.countryPlayer.PopulationCount / enterNation.countryPlayer.regions.Count / 100;
            enterNation.countryPlayer.KilkistyRecruit = enterNation.countryPlayer.PopulationCount / (100 / enterNation.countryPlayer.ProcentViyskovoZob) - start.kilkNayn;
            enterNation.countryPlayer.Money += dohid + dohidPod;
            enterNation.countryPlayer.BuildResourse += dohid;
            enterNation.countryPlayer.Stail += dohidStail;
            enterNation.countryPlayer.Topluvo += dohidOil;
            enterNation.countryPlayer.Kauchuk += dohidOil / 10;

            //Technology
            if (currentTech != null)
            {
                if (start.TechnologyList[idTech].Time != 0)
                {
                    currentTech.Time -= 1;
                    start.TechnologyList[idTech].Time -= 1;
                    if (start.TechnologyList[idTech].Time == 0)
                    {
                        start.TechnologyList[idTech].isOpen = true;
                        enterNation.countryPlayer.techs.Add(currentTech);
                        currentTech = null;
                        enterNation.countryPlayer.openPolks = new List<Polk>();
                        enterNation.countryPlayer.openBuilds = new List<Build>();
                        for (int i = 0; i < enterNation.countryPlayer.techs.Count; i++)
                        {
                            if (enterNation.countryPlayer.techs[i].polks != null)
                            {
                                for (int j = 0; j < enterNation.countryPlayer.techs[i].polks.Count; j++)
                                {
                                    enterNation.countryPlayer.openPolks.Add(enterNation.countryPlayer.techs[i].polks[j]);
                                }
                            }
                            else if (enterNation.countryPlayer.techs[i].builds != null)
                            {
                                for (int j = 0; j < enterNation.countryPlayer.techs[i].builds.Count; j++)
                                {
                                    enterNation.countryPlayer.openBuilds.Add(enterNation.countryPlayer.techs[i].builds[j]);
                                }
                            }
                        }
                    }
                }
            }

            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}