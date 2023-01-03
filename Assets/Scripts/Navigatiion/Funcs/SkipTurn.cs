using Assets.Class.Army;
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
        public MessagesMechanic messagesMechanic;
        public CreateArmy createArmy;
        public CreateAir createAir;
        public CreateFlot createFlot;
        public Text textTime;
        public DateTime Time;
        int day = 1;
        int mounth = 1;
        int year = 1936;
        int dohid = 0;
        int dohidStail = 0;
        int dohidOil = 0;
        int dohidPod = 0;
        public int idTech = 0;
        public Technology currentTech;
        public List<Build> currentBuild;
        public Division currentDiv;
        public Air currentAir;
        public Flot currentFlot;
        public List<int> idsRegions = new List<int>();
        public List<MoveDivisionClass> listMovedDiv = new List<MoveDivisionClass>();
        public List<MoveAirClass> listMovedAir = new List<MoveAirClass>();
        public List<MoveFlotClass> listMovedFlot = new List<MoveFlotClass>();

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
                if (enterNation.countryPlayer.techs[i].builds != null)
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
                        messagesMechanic.Messages.text += "Technology named " + currentTech.Name + " open on " + Time.ToString() + "\n";
                        currentTech = new Technology();
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
                            if (enterNation.countryPlayer.techs[i].builds != null)
                            {
                                for (int j = 0; j < enterNation.countryPlayer.techs[i].builds.Count; j++)
                                {
                                    enterNation.countryPlayer.openBuilds.Add(enterNation.countryPlayer.techs[i].builds[j]);
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].typeTech == TypeTech.Viyskov)
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openBuilds.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openBuilds[j].Type == TypeBuild.Big)
                                    {
                                        enterNation.countryPlayer.openBuilds[i].Price -= (enterNation.countryPlayer.openBuilds[j].Price / 100) * enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            //1936
                            if (enterNation.countryPlayer.techs[i].Name == "Construction I" || enterNation.countryPlayer.techs[i].Name == "Construction II" || enterNation.countryPlayer.techs[i].Name == "Construction III" || enterNation.countryPlayer.techs[i].Name == "Construction IV" || enterNation.countryPlayer.techs[i].Name == "Construction V" || enterNation.countryPlayer.techs[i].Name == "Construction VI" || enterNation.countryPlayer.techs[i].Name == "Construction VII" || enterNation.countryPlayer.techs[i].Name == "Construction VIII")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openBuilds.Count; j++)
                                {
                                    enterNation.countryPlayer.openBuilds[j].Dohid += enterNation.countryPlayer.techs[i].PlusCiv;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Electronic mechanical engineering" || enterNation.countryPlayer.techs[i].Name == "Radio" || enterNation.countryPlayer.techs[i].Name == "Decimetric radar" || enterNation.countryPlayer.techs[i].Name == "Improved decimetric radar" || enterNation.countryPlayer.techs[i].Name == "Centimetric radar" || enterNation.countryPlayer.techs[i].Name == "Improved centimetric radar" || enterNation.countryPlayer.techs[i].Name == "Advanced centimetric radar")
                            {
                                Debug.Log(enterNation.countryPlayer.techs[i].PlusCount);
                                enterNation.countryPlayer.Stabilnisty += enterNation.countryPlayer.techs[i].PlusCount;
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Infantry Equipment I")
                            {
                                for (int j  = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Fighter I and Bomber I")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Flot I" || enterNation.countryPlayer.techs[i].Name == "Flot II" || enterNation.countryPlayer.techs[i].Name == "Flot III" || enterNation.countryPlayer.techs[i].Name == "Flot IV" || enterNation.countryPlayer.techs[i].Name == "Flot V")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;

                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Superior Firepower")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Artillery")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Mass Assault")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Price -= (enterNation.countryPlayer.openPolks[j].Price / 100 ) * enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Air Superiority")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Formation Flying")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Force Rotation")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Fleet In Being")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Trade Interdiction")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Base Strike")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1937
                            if (enterNation.countryPlayer.techs[i].Name == "Delay Mob War")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Delay")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Grand Battle Plan")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    enterNation.countryPlayer.openPolks[j].Price -= (enterNation.countryPlayer.openPolks[j].Price / 100) * enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Infrastructure Destruction")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Dive Bombing")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Fighter Baiting")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Submarine Operations")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Carrier Operations")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Convoy Escorts")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1938
                            if (enterNation.countryPlayer.techs[i].Name == "Improved Infantry Equipment I")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Elastic Defense")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Light Tank" || enterNation.countryPlayer.openPolks[j].Name == "Medium Tank" || enterNation.countryPlayer.openPolks[j].Name == "Heavy Tank" || enterNation.countryPlayer.openPolks[j].Name == "Btr")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Mobile Defense")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Prepared Defense")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Defense in Depth")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Naval Strike Tactics")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Direct Ground Support")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Low Echelon Support")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Convoy Escorts in Being")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Capital Ship Raiders")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Undersea Blockade")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1939
                            if (enterNation.countryPlayer.techs[i].Name == "Improved Infantry Equipment II")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Armored Spearhead")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Light Tank" || enterNation.countryPlayer.openPolks[j].Name == "Medium Tank" || enterNation.countryPlayer.openPolks[j].Name == "Heavy Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Dispersed Support")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Artillery")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Grand Assault")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "People's Army")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Garrizon")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Dogfighting Experience")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Fighter Ace Initiative")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Dispersed Fighting")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Convoy Interdiction")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Subsidiary Carrier Role")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Floating Airfield")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1940
                            if (enterNation.countryPlayer.techs[i].Name == "Improved Infantry Equipment III")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Fighter II and Bomber II")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;

                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Schwerpunkt")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Light Tank" || enterNation.countryPlayer.openPolks[j].Name == "Medium Tank" || enterNation.countryPlayer.openPolks[j].Name == "Heavy Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Overwhelming Firepower")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Artillery")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Mechanized Offensive")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Garrizon" || enterNation.countryPlayer.openPolks[j].Name == "Motorized" || enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Infantry Offensive")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Multi-Altitude Flying")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Hunt and Destroy")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Operational Destruction")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Integrated Convoy Defense")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Advanced Submarine Warfare")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Submarine Offensive")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1941
                            if (enterNation.countryPlayer.techs[i].Name == "Light Tank II")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Light Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Medium Tank II")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Medium Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Heavy Tank II")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Heavy Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Mechanized Offensive I")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Light Tank" || enterNation.countryPlayer.openPolks[j].Name == "Medium Tank" || enterNation.countryPlayer.openPolks[j].Name == "Heavy Tank")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Blitzkrieg")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Assault Concentration")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Large Front Offensive")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Logistical Bombing")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Combat Unit Destruction")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Ground Attack Veteran Initiative")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Floating Airfield")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Combined Operations Raiding")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Floating Fortress")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1942
                            if (enterNation.countryPlayer.techs[i].Name == "Mechanized Equipment II")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Mechanized")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Kampfgruppe")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                        enterNation.countryPlayer.openPolks[j].Bronya += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Centralized Fire Control")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota" || enterNation.countryPlayer.openPolks[j].Name == "Artillery")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Branch Inter-Operation")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Human Wave Offensive")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Pihota")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Night Bombing")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Battlefield Support")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Carousel Bombing")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Grand Battlefleet")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Carrier Battlegroups")
                            {
                                for (int j = 0; j < start.FlotList.Count; j++)
                                {
                                    start.FlotList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            //1943
                            if (enterNation.countryPlayer.techs[i].Name == "Volkssturm")
                            {
                                enterNation.countryPlayer.ProcentViyskovoZob += enterNation.countryPlayer.techs[i].PlusArm;
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Forward Observers")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    if (enterNation.countryPlayer.openPolks[j].Name == "Artillery")
                                    {
                                        enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                    }
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Guerrilla Warfare")
                            {
                                for (int j = 0; j < enterNation.countryPlayer.openPolks.Count; j++)
                                {
                                    enterNation.countryPlayer.openPolks[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Massed Bomber Formations")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Naval Strike Torpedo Tactics")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Damage += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }
                            if (enterNation.countryPlayer.techs[i].Name == "Infiltration Bombing")
                            {
                                for (int j = 0; j < start.AirList.Count; j++)
                                {
                                    start.AirList[j].Hit += enterNation.countryPlayer.techs[i].PlusArm;
                                }
                            }

                        }
                    }
                }
            }

            //Builds
            if (currentBuild != null)
            {
                for (int i = 0; i < currentBuild.Count; i++)
                {
                    if (currentBuild[i].kilkTurns != 0)
                    {
                        currentBuild[i].kilkTurns -= 1;
                        if (currentBuild[i].kilkTurns == 0)
                        {
                            enterNation.countryPlayer.regions[idsRegions[i]].builds.Add(currentBuild[i]);
                            messagesMechanic.Messages.text += "Build in region " + enterNation.countryPlayer.regions[idsRegions[i]].Name + " named " + currentBuild[i].Name + " on " + Time.ToString() + "\n";
                            currentBuild.Remove(currentBuild[i]);
                            idsRegions.Remove(idsRegions[i]);
                        }
                    }
                }
            }

            //Create div
            if (currentDiv.Name != " ")
            {
                if (currentDiv.kilkturns != 0)
                {
                    currentDiv.kilkturns -= 1;

                    if (currentDiv.kilkturns == 0)
                    {
                        enterNation.countryPlayer.regions[createArmy.idRegion].divisions.Add(currentDiv);
                        messagesMechanic.Messages.text += "Create division in region " + enterNation.countryPlayer.regions[createArmy.idRegion].Name + " named " + currentDiv.Name + " on " + Time.ToString() + "\n";
                        currentDiv = new Division();
                    }
                }
            }

            //Create air
            if (currentAir != null)
            {
                if (currentAir.kilkturns != 0)
                {
                    currentAir.kilkturns -= 1;

                    if (currentAir.kilkturns == 0)
                    {
                        enterNation.countryPlayer.regions[createAir.idRegion].airs.Add(currentAir);
                        messagesMechanic.Messages.text += "Create air in region " + enterNation.countryPlayer.regions[createAir.idRegion].Name + " named " + currentAir.Name + " on " + Time.ToString() + "\n";
                        currentAir = new Air();
                    }
                }
            }

            //Create flot
            if (currentFlot != null)
            {
                if (currentFlot.kilkturns != 0)
                {
                    currentFlot.kilkturns -= 1;

                    if (currentFlot.kilkturns == 0)
                    {
                        enterNation.countryPlayer.regions[createFlot.idRegion].flotiliya.Add(currentFlot);
                        messagesMechanic.Messages.text += "Create flot in region " + enterNation.countryPlayer.regions[createFlot.idRegion].Name + " named " + currentFlot.Name + " on " + Time.ToString() + "\n";
                        currentFlot = new Flot();
                    }
                }
            }

            //Move div
            if (listMovedDiv != null)
            {
                for (int i = 0; i < listMovedDiv.Count; i++)
                {
                    if (listMovedDiv[i].kilkTurns != 0)
                    {
                        listMovedDiv[i].kilkTurns -= 1;

                        if (listMovedDiv[i].kilkTurns == 0)
                        {
                            enterNation.countryPlayer.regions[listMovedDiv[i].idEndReg].divisions.Add(listMovedDiv[i].movedDiv);
                            messagesMechanic.Messages.text += "Moved division for region " + enterNation.countryPlayer.regions[listMovedDiv[i].idStartReg].Name + " to " + enterNation.countryPlayer.regions[listMovedDiv[i].idEndReg].Name + " on " + Time.ToString() + "\n";
                            listMovedDiv.Remove(listMovedDiv[i]);
                        }
                    }
                }
            }

            //Move air
            if (listMovedAir != null)
            {
                for (int i = 0; i < listMovedAir.Count; i++)
                {
                    if (listMovedAir[i].kilkTurns != 0)
                    {
                        listMovedAir[i].kilkTurns -= 1;

                        if (listMovedAir[i].kilkTurns == 0)
                        {
                            enterNation.countryPlayer.regions[listMovedAir[i].idEndReg].airs.Add(listMovedAir[i].movedAir);
                            messagesMechanic.Messages.text += "Moved air for region " + enterNation.countryPlayer.regions[listMovedDiv[i].idStartReg].Name + " to " + enterNation.countryPlayer.regions[listMovedAir[i].idEndReg].Name + " on " + Time.ToString() + "\n";
                            listMovedAir.Remove(listMovedAir[i]);
                        }
                    }
                }
            }

            //Move flot
            if (listMovedFlot != null)
            {
                for (int i = 0; i < listMovedFlot.Count; i++)
                {
                    if (listMovedFlot[i].kilkTurns != 0)
                    {
                        listMovedFlot[i].kilkTurns -= 1;

                        if (listMovedFlot[i].kilkTurns == 0)
                        {
                            enterNation.countryPlayer.regions[listMovedFlot[i].idEndReg].flotiliya.Add(listMovedFlot[i].movedFlot);
                            messagesMechanic.Messages.text += "Moved flot for region " + enterNation.countryPlayer.regions[listMovedFlot[i].idStartReg].Name + " to " + enterNation.countryPlayer.regions[listMovedFlot[i].idEndReg].Name + " on " + Time.ToString() + "\n";
                            listMovedFlot.Remove(listMovedFlot[i]);
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