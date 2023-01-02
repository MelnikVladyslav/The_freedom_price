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
            if (currentDiv != null)
            {
                if (currentDiv.kilkturns != 0)
                {
                    currentDiv.kilkturns -= 1;

                    if (currentDiv.kilkturns == 0)
                    {
                        enterNation.countryPlayer.regions[createArmy.idRegion].divisions.Add(currentDiv);
                        messagesMechanic.Messages.text += "Create division in region " + enterNation.countryPlayer.regions[createArmy.idRegion].Name + " named " + currentDiv.Name + " on " + Time.ToString() + "\n";
                        currentDiv = null;
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
                        currentAir = null;
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
                        currentFlot = null;
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
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}