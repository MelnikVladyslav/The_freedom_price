using Assets.Scripts.Navigatiion.Funcs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.PlayerStrategy
{
    public class ReichStrategy : MonoBehaviour
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
        int kilkBalMon = 0;
        bool isViysStan = false;
        Idelogies PP = Idelogies.Fascism;
        int currentYear = 1936;

        // Use this for initialization
        void Start()
        {

        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "Third Reich")
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
                    if (kilkYear == 1)
                    {
                        Golosuvanya.gameObject.SetActive(true);
                    }
                    if (kilkYear == 0)
                    {
                        kilkYear = 5;

                        int maxR = Mathf.Max(kilkBalDem, kilkBalFac);
                        int maxL = Mathf.Max(kilkBalCom, kilkBalMon);

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            if (maxR > maxL)
                            {
                                if (kilkBalDem < kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Fascism;

                                    infoText.text = "In this vubor win to " + Idelogies.Fascism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Third Reich" && start.liderList[i].idelogies == Idelogies.Fascism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[0];
                                    kilkBalFac = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalDem > kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Democraty;

                                    infoText.text = "In this vubor win to " + Idelogies.Democraty.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Third Reich" && start.liderList[i].idelogies == Idelogies.Democraty)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[1];

                                    kilkBalMon = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                            if (maxL > maxR)
                            {
                                if (kilkBalCom < kilkBalMon)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Monarchy;

                                    infoText.text = "In this vubor win to " + Idelogies.Monarchy.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Third Reich" && start.liderList[i].idelogies == Idelogies.Monarchy)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[2];
                                    kilkBalMon = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalCom > kilkBalMon)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Communism;

                                    infoText.text = "In this vubor win to " + Idelogies.Communism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Third Reich" && start.liderList[i].idelogies == Idelogies.Communism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[3];

                                    kilkBalMon = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                        }

                        ResultVub.gameObject.SetActive(true);
                    }
                }

                //Viyskovuy stan
                if (skipTurn.Time.Year > currentYear)
                {
                    currentYear = skipTurn.Time.Year;
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
                }

            }
            else
            {
                Debug.Log("Is ai");
            }
        }
    }
}