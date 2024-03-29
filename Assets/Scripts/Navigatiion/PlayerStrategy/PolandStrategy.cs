﻿using Assets.Scripts.Navigatiion.Funcs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.PlayerStrategy
{
    public class PolandStrategy : MonoBehaviour
    {
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public StartScriptsInitilazer start;
        public bool isPlayer;
        public GameObject Golosuvanya;
        public GameObject EnterOP;
        public GameObject ResultVub;
        public GameObject ViyskovuyStan;
        public Text infoText;
        public RawImage fotoIventResVub;
        public List<Texture> listFlagsForIdeol;
        int kilkYear = 5;
        int kilkBalCom = 0;
        int kilkBalDem = 0;
        int kilkBalFac = 0;
        int kilkBalNet = 0;
        int kilkBalMon = 0;
        bool isViysStan = false;
        Idelogies PP = Idelogies.Neutrall;
        int currentYear = 1936;

        // Use this for initialization
        void Start()
        {

        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "Poland")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Vuboru
        public void PidPP()
        {
            enterNation.countryPlayer.Popularity += 5;

            Golosuvanya.gameObject.SetActive(false);
        }

        public void PidOP()
        {
            enterNation.countryPlayer.Popularity -= 5;

            Golosuvanya.gameObject.SetActive(false);
            EnterOP.gameObject.SetActive(true);

        }

        public void EnterFac()
        {
            kilkBalFac++;
            EnterOP.gameObject.SetActive(false);
        }

        public void EnterDem()
        {
            kilkBalDem++;
            EnterOP.gameObject.SetActive(false);
        }

        public void Entercom()
        {
            kilkBalCom++;
            EnterOP.gameObject.SetActive(false);
        }

        public void EnterMon()
        {
            kilkBalMon++;
            EnterOP.gameObject.SetActive(false);
        }

        //ViyskovuyStan
        public void EnterViyskovStan()
        {
            isViysStan = true;

            enterNation.countryPlayer.ProcentViyskovoZob += 20;

            enterNation.countryPlayer.Stabilnisty += 10;
        }

        // Update is called once per frame
        void Update()
        {
            isPlayer = Perevirka();
            bool isWar = false;

            if (isPlayer == true)
            {
                // Vuboru
                if (skipTurn.Time.Year > currentYear)
                {
                    currentYear = skipTurn.Time.Year;

                    if (kilkYear <= 5 && kilkYear != 0)
                    {
                        kilkYear--;
                    }
                    Golosuvanya.gameObject.SetActive(true);
                    if (kilkYear == 0)
                    {
                        kilkYear = 5;

                        int maxR = Mathf.Max(kilkBalMon, kilkBalFac);
                        int maxL = Mathf.Max(kilkBalCom, kilkBalDem);

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            if (maxR > maxL)
                            {
                                if (kilkBalMon < kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Fascism;

                                    infoText.text = "In this vubor win to " + Idelogies.Fascism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Poland" && start.liderList[i].idelogies == Idelogies.Fascism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[0];
                                    kilkBalFac = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalMon > kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Monarchy;

                                    infoText.text = "In this vubor win to " + Idelogies.Monarchy.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Poland" && start.liderList[i].idelogies == Idelogies.Monarchy)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[1];
                                    kilkBalFac = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                            if (maxL > maxR)
                            {
                                if (kilkBalCom < kilkBalDem)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Democraty;

                                    infoText.text = "In this vubor win to " + Idelogies.Democraty.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Poland" && start.liderList[i].idelogies == Idelogies.Democraty)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[2];
                                    kilkBalDem = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalCom > kilkBalDem)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Communism;

                                    infoText.text = "In this vubor win to " + Idelogies.Communism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Poland" && start.liderList[i].idelogies == Idelogies.Communism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[3];

                                    kilkBalCom = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                        }

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            ResultVub.gameObject.SetActive(true);
                        }
                    }

                    //Viyskovuy stan 
                    for (int i = 0; i < start.CountryList.Count; i++)
                    {
                        if (start.CountryList[i].Types == TypeCountry.Enemy)
                        {
                            isWar = true;
                            break;
                        }
                    }

                    if (isWar)
                    {
                        if (isViysStan)
                        {
                            ViyskovuyStan.gameObject.SetActive(true);
                        }
                    }
                    else
                    {
                        isViysStan = false;
                    }

                    //Facism
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism && skipTurn.Time.Year == 1941)
                    {
                        start.CountryList[0].regions.Add(start.RegionList[182]);
                        start.CountryList[29].regions.Remove(start.RegionList[182]);

                        if (start.CountryList[0].NameAlliens == "" )
                        {
                            start.CountryList[0].NameAlliens = "Axis";
                            start.CountryList[9].NameAlliens = "Axis";
                            start.CountryList[0].Types = TypeCountry.Alliens;
                        }
                        if (start.CountryList[0].NameAlliens == "Axis")
                        {
                            start.CountryList[9].NameAlliens = "Axis";
                            start.CountryList[0].Types = TypeCountry.Alliens;
                        }
                    }

                    //cummunism
                    if (enterNation.countryPlayer.idelogy == Idelogies.Communism && skipTurn.Time.Year == 1941)
                    {
                        start.CountryList[8].regions.Add(start.RegionList[106]);
                        start.CountryList[9].regions.Remove(start.RegionList[106]);

                        if (start.CountryList[8].NameAlliens == "")
                        {
                            start.CountryList[8].NameAlliens = "comintern";
                            start.CountryList[9].NameAlliens = "comintern";
                            start.CountryList[8].Types = TypeCountry.Alliens;
                        }
                        if (start.CountryList[8].NameAlliens == "comintern")
                        {
                            start.CountryList[9].NameAlliens = "comintern";
                            start.CountryList[8].Types = TypeCountry.Alliens;
                        }
                    }

                    //Democraty
                    if (enterNation.countryPlayer.idelogy == Idelogies.Democraty && skipTurn.Time.Year == 1941)
                    {
                        for (int i = 0; i < start.CountryList.Count; i++)
                        {
                            if (start.CountryList[i].idelogy == Idelogies.Democraty)
                            {
                                if (start.CountryList[i].NameAlliens == "")
                                {
                                    start.CountryList[i].NameAlliens = "Michmorya";
                                    start.CountryList[9].NameAlliens = "Michmorya";
                                    start.CountryList[i].Types = TypeCountry.Alliens;
                                }
                            }
                        }
                    }

                    //Monarchy
                    if (enterNation.countryPlayer.idelogy == Idelogies.Monarchy)
                    {
                        if (skipTurn.Time.Year == 1941)
                        {
                            start.CountryList[11].Types = TypeCountry.Enemy;
                            start.CountryList[12].Types = TypeCountry.Enemy;
                            start.CountryList[13].Types = TypeCountry.Enemy;
                        }
                        if (skipTurn.Time.Year == 1942)
                        {
                            start.CountryList[1].Types = TypeCountry.Enemy;
                        }
                        if (skipTurn.Time.Year == 1943)
                        {
                            start.CountryList[0].Types = TypeCountry.Enemy;
                        }
                        if (skipTurn.Time.Year == 1944)
                        {
                            start.CountryList[8].Types = TypeCountry.Enemy;
                        }
                    }
                }

            }
            else
            {

            }
        }
    }
}