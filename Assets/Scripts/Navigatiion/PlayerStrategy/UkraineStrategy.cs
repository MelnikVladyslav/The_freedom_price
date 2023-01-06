using Assets.Scripts.Navigatiion.Funcs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.PlayerStrategy
{
    public class UkraineStrategy : MonoBehaviour
    {
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public StartScriptsInitilazer start;
        public bool isPlayer;
        public GameObject Golosuvanya;
        public GameObject EnterOP;
        public GameObject ResultVub;
        public GameObject ViyskovuyStan;
        public GameObject SystemBVsM;
        public GameObject EnterAlianceWithGer;
        public Text infoText;
        public RawImage fotoIventResVub;
        public List<Texture> listFlagsForIdeol;
        int kilkYear = 5;
        int kilkBalCom = 0;
        int kilkBalDem = 0;
        int kilkBalFac = 0;
        int kilkBalNat = 0;
        int kilkBalMon = 0;
        int kilkBalAna = 0;
        bool isViysStan = false;
        Idelogies PP = Idelogies.Nationalism;
        int currentYear = 1936;
        bool isOkAlGer = false;

        // Use this for initialization
        void Start()
        {

        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "Soborna Ukraine")
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

        public void EnterAna()
        {
            kilkBalAna++;
            EnterOP.gameObject.SetActive(false);
        }

        //ViyskovuyStan
        public void EnterViyskovStan()
        {
            isViysStan = true;

            enterNation.countryPlayer.ProcentViyskovoZob += 20;

            enterNation.countryPlayer.Stabilnisty += 10;
        }

        //System BanderaVsMelnik
        public void EnterBandera()
        {
            kilkBalNat++;

            SystemBVsM.gameObject.SetActive(false);
        }

        public void EnterMelnik()
        {
            kilkBalFac++;

            SystemBVsM.gameObject.SetActive(false);
        }

        public void Ok()
        {
            isOkAlGer = true;

            EnterAlianceWithGer.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            isPlayer = Perevirka();
            bool isWar = false;

            if (isPlayer == true)
            {
                if (skipTurn.Time.Year > currentYear)
                {
                    // Vuboru
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

                        int maxR = Mathf.Max(kilkBalNat, kilkBalFac);
                        int maxL = Mathf.Max(kilkBalCom, kilkBalAna);
                        int maxN = Mathf.Max(kilkBalMon, kilkBalDem);

                        if (enterNation.countryPlayer.Popularity < 50)
                        {
                            if (maxR > maxL && maxR > maxN)
                            {
                                if (kilkBalNat < kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Fascism;

                                    infoText.text = "In this vubor win to " + Idelogies.Fascism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Fascism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[0];
                                    kilkBalFac = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalNat > kilkBalFac)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Nationalism;

                                    infoText.text = "In this vubor win to " + Idelogies.Nationalism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Nationalism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[0];
                                    kilkBalNat = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                            if (maxL > maxR && maxL > maxN)
                            {
                                if (kilkBalCom < kilkBalAna)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Anarchy;

                                    infoText.text = "In this vubor win to " + Idelogies.Anarchy.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Anarchy)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[1];
                                    kilkBalAna = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalCom > kilkBalAna)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Communism;

                                    infoText.text = "In this vubor win to " + Idelogies.Communism.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Communism)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[2];

                                    kilkBalCom = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }
                            if (maxN > maxL && maxN > maxR)
                            {
                                if (kilkBalDem < kilkBalMon)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Monarchy;

                                    infoText.text = "In this vubor win to " + Idelogies.Monarchy.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Monarchy)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[3];

                                    kilkBalMon = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                                if (kilkBalDem > kilkBalMon)
                                {
                                    enterNation.countryPlayer.idelogy = Idelogies.Democraty;

                                    infoText.text = "In this vubor win to " + Idelogies.Democraty.ToString() + " party.";
                                    for (int i = 0; i < start.liderList.Count; i++)
                                    {
                                        if (start.liderList[i].country.Name == "Soborna Ukraine" && start.liderList[i].idelogies == Idelogies.Democraty)
                                        {
                                            fotoIventResVub.texture = start.liderList[i].foto;
                                        }
                                    }
                                    enterNation.countryPlayer.Flag = listFlagsForIdeol[4];

                                    kilkBalDem = 0;

                                    enterNation.countryPlayer.Popularity = (100 - enterNation.countryPlayer.Popularity);
                                }
                            }

                            ResultVub.gameObject.SetActive(true);
                        }
                    }

                    //Viyskovuy stan
                    if (isWar != true)
                    {
                        currentYear = skipTurn.Time.Year;

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

                    //System BanderaVsMelnik
                    if (enterNation.countryPlayer.idelogy == Idelogies.Nationalism)
                    {
                        currentYear = skipTurn.Time.Year;

                        if (kilkBalNat < 4)
                        {
                            SystemBVsM.gameObject.SetActive(true);
                        }

                        if (kilkBalFac >= 4)
                        {
                            if (start.CountryList[1].NameAlliens == "" && !isOkAlGer)
                            {
                                EnterAlianceWithGer.gameObject.SetActive(true);
                            }
                            if (start.CountryList[0].NameAlliens == "" && isOkAlGer == true)
                            {
                                start.CountryList[0].NameAlliens = "Axis";
                                start.CountryList[1].NameAlliens = "Axis";
                                start.CountryList[0].Types = TypeCountry.Alliens;
                            }
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