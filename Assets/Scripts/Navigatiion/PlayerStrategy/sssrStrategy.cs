﻿using Assets.Scripts.Navigatiion.Funcs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.PlayerStrategy
{
    public class sssrStrategy : MonoBehaviour
    {
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public StartScriptsInitilazer start;
        public bool isPlayer;
        public GameObject Golosuvanya;
        public GameObject EnterOP;
        public GameObject ResultVub;
        public GameObject ViyskovuyStan;
        public GameObject Reforms;
        public Text infoText;
        public RawImage fotoIventResVub;
        public List<Texture> listFlagsForIdeol;
        int kilkYear = 5;
        int kilkBalCom = 0;
        int kilkBalViyskCom = 0;
        int kilkBalFac = 0;
        int kilkBalMon = 0;
        bool isViysStan = false;
        Idelogies PP = Idelogies.Communism;
        int currentYear = 1936;
        int kilkRefArmy = 0;
        bool isRev = false;

        // Use this for initialization
        void Start()
        {

        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "sssr" || enterNation.countryPlayer.Name == "ussr" || enterNation.countryPlayer.Name == "bila russia")
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

        public void EnterMon()
        {
            kilkBalMon++;
            EnterOP.gameObject.SetActive(false);
        }

        public void EnterViyskCom()
        {
            kilkBalViyskCom++;
            EnterOP.gameObject.SetActive(false);
        }

        //ViyskovuyStan
        public void EnterViyskovStan()
        {
            isViysStan = true;

            enterNation.countryPlayer.ProcentViyskovoZob += 20;

            enterNation.countryPlayer.Stabilnisty += 10;
        }

        //Reforms
        public void Reform()
        {
            kilkRefArmy++;
        }

        // Update is called once per frame
        void Update()
        {
            isPlayer = Perevirka();

            if (isPlayer == true)
            {
                if (skipTurn.Time.Year > currentYear)
                {
                    currentYear = skipTurn.Time.Year;

                    // Vuboru
                    if (kilkYear <= 5 && kilkYear != 0)
                    {
                        kilkYear--;
                    }
                    Golosuvanya.gameObject.SetActive(true);
                    if (kilkYear == 0)
                    {
                        kilkYear = 5;

                        int maxR = Mathf.Max(kilkBalMon, kilkBalFac);

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            if (maxR > kilkBalViyskCom)
                            {
                                if (kilkBalMon < kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Fascism;

                                    infoText.text = "In this vubor win to " + Idelogies.Fascism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "sssr" && start.liderList[i].idelogies == Idelogies.Fascism)
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
                                        if (start.liderList[i].country.Name == "sssr" && start.liderList[i].idelogies == Idelogies.Monarchy)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[1];
                                    kilkBalFac = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                            if (maxR < kilkBalViyskCom)
                            {
                                enterNation.countryPlayer.idelogy = Idelogies.ViyskovuyCummunism;

                                infoText.text = "In this vubor win to " + Idelogies.ViyskovuyCummunism.ToString() + " party.";
                                for (int i = 0; i < start.liderList.Count; i++)
                                {
                                    if (start.liderList[i].country.Name == "sssr" && start.liderList[i].idelogies == Idelogies.ViyskovuyCummunism)
                                    {
                                        fotoIventResVub.texture = start.liderList[i].foto;
                                    }
                                }
                                enterNation.countryPlayer.Flag = listFlagsForIdeol[2];
                                kilkBalViyskCom = 0;

                                enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                
                            }
                        }

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            ResultVub.gameObject.SetActive(true);
                        }
                    }

                    //Viyskovuy stan
                    bool isWar = false;

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

                    //Reforms
                    if (enterNation.countryPlayer.idelogy == Idelogies.Communism)
                    {
                        Reforms.gameObject.SetActive(true);
                    }
                    if (kilkRefArmy == 1)
                    {
                        enterNation.countryParametrs.text = "";
                        enterNation.atack = 0;
                        enterNation.def = 0;
                    }

                    if (skipTurn.Time.Year == 1941)
                    {
                        start.CountryList[1].Types = TypeCountry.Enemy;
                    }

                    if (skipTurn.Time.Year == 1939 && enterNation.countryPlayer.idelogy == Idelogies.Communism)
                    {
                        start.CountryList[8].Types = TypeCountry.Enemy;
                    }
                }

            }
            else
            {

            }
        }
    }
}