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
        public GameObject PidtrumkaBalk;
        public GameObject Ancluss;
        public GameObject MunichZrada;
        public GameObject SudbaChech;
        public GameObject PolandW;
        public Text infoText;
        public RawImage fotoIventResVub;
        public List<Texture> listFlagsForIdeol;
        int kilkYear = 5;
        int kilkBalCom = 0;
        int kilkBalDem = 0;
        int kilkBalFac = 0;
        int kilkBalMon = 0;
        int kilkBalPidtr = 0;
        bool isViysStan = false;
        Idelogies PP = Idelogies.Fascism;
        int currentYear = 1936;
        bool isWar = false;

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

        //Pidtrumka balkan
        public void Pidtr()
        {
            kilkBalPidtr++;

            PidtrumkaBalk.gameObject.SetActive(false);
        }

        //Nazi
        //Ancluss
        public void Anclus()
        {
            start.CountryList[0].regions.Add(start.RegionList[152]);
            start.CountryList[0].regions.Add(start.RegionList[153]);

            start.CountryList[24].regions.Remove(start.RegionList[152]);
            start.CountryList[24].regions.Remove(start.RegionList[153]);

            Ancluss.gameObject.SetActive(false);
        }

        //Munich
        public void MunichZrad()
        {
            MunichZrada.gameObject.SetActive(false);
        }

        //SudbaChech
        public void SudbaChec()
        {
            start.CountryList[0].regions.Add(start.RegionList[149]);
            start.CountryList[0].regions.Add(start.RegionList[150]);
            start.CountryList[0].regions.Add(start.RegionList[151]);

            start.CountryList[23].regions.Remove(start.RegionList[149]);
            start.CountryList[23].regions.Remove(start.RegionList[150]);
            start.CountryList[23].regions.Remove(start.RegionList[151]);

            SudbaChech.gameObject.SetActive(false);
        }

        //Poland
        public void PolandWar()
        {
            start.CountryList[8].Types = TypeCountry.Enemy;

            PolandW.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            isPlayer = Perevirka();

            if (isPlayer == true)
            {
                if (skipTurn.Time.Year > currentYear)
                {
                    //Vuboru
                    currentYear = skipTurn.Time.Year;

                    if (kilkYear <= 5 && kilkYear != 0)
                    {
                        kilkYear--;
                    }
                    Golosuvanya.gameObject.SetActive(true);
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

                    //Pidtrumka Balkans
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism)
                    {
                        if (kilkBalPidtr <= 3)
                        {
                            PidtrumkaBalk.gameObject.SetActive(true);
                        }

                        if (kilkBalPidtr >= 3)
                        {
                            start.CountryList[5].Types = TypeCountry.Alliens;
                            start.CountryList[7].Types = TypeCountry.Alliens;
                            start.CountryList[10].Types = TypeCountry.Alliens;
                        }
                    }

                    //SS
                    bool isDiv = false;
                    int currDiv = 0;
                    for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
                    {
                        if (enterNation.countryPlayer.regions[i].Name == "Riga")
                        {
                            for (int j = 0; j < enterNation.countryPlayer.regions[i].divisions.Count; j++)
                            {
                                if (enterNation.countryPlayer.regions[i].divisions[j].Name == "VI Corps SS")
                                {
                                    isDiv = true;
                                }
                                else
                                {
                                    isDiv = false;
                                }
                            }
                            if (!isDiv)
                            {
                                enterNation.countryPlayer.regions[i].divisions.Add(new Division()
                                {
                                    Name = "VI Corps SS",
                                    polks = new List<Polk>()
                                    {
                                        new Polk
                                        {
                                            Name = "Artillery",
                                            Type = TypePolk.Artilery,
                                            Price = 150,
                                            Hit = 100,
                                            Damage = 40,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[2]
                                        },
                                        new Polk
                                        {
                                            Name = "Artillery",
                                            Type = TypePolk.Artilery,
                                            Price = 150,
                                            Hit = 100,
                                            Damage = 40,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[2]
                                        },
                                        new Polk
                                        {
                                            Name = "Motorized",
                                            Type = TypePolk.Motorized,
                                            Price = 150,
                                            Hit = 150,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 3,
                                            icon = start.icons[4]
                                        },
                                        new Polk
                                        {
                                            Name = "Pihota",
                                            Type = TypePolk.Pihota,
                                            Price = 100,
                                            Hit = 100,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[1]
                                        },
                                        new Polk
                                        {
                                            Name = "Pihota",
                                            Type = TypePolk.Pihota,
                                            Price = 100,
                                            Hit = 100,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[1]
                                        },
                                        new Polk
                                        {
                                            Name = "Pihota",
                                            Type = TypePolk.Pihota,
                                            Price = 100,
                                            Hit = 100,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[1]
                                        },
                                        new Polk
                                        {
                                            Name = "Pihota",
                                            Type = TypePolk.Pihota,
                                            Price = 100,
                                            Hit = 100,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[1]
                                        },
                                        new Polk
                                        {
                                            Name = "Pihota",
                                            Type = TypePolk.Pihota,
                                            Price = 100,
                                            Hit = 100,
                                            Damage = 30,
                                            Bronya = 0,
                                            Step = 1,
                                            icon = start.icons[1]
                                        }
                                    }
                                });

                                for (int j = 0; j < enterNation.countryPlayer.regions[i].divisions.Count; j++)
                                {
                                    if (enterNation.countryPlayer.regions[i].divisions[j].Name == "VI Corps SS")
                                    {
                                        currDiv = j;
                                    }
                                }

                                for (int j = 0; j < enterNation.countryPlayer.regions[i].divisions[currDiv].polks.Count; j++)
                                {
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].ZagDam += enterNation.countryPlayer.regions[i].divisions[currDiv].polks[j].Damage;
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].ZagStep += enterNation.countryPlayer.regions[i].divisions[currDiv].polks[j].Step;
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].ZagBr += enterNation.countryPlayer.regions[i].divisions[currDiv].polks[j].Bronya;
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].ZagHit += enterNation.countryPlayer.regions[i].divisions[currDiv].polks[j].Hit;
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].Price += enterNation.countryPlayer.regions[i].divisions[currDiv].polks[j].Price;
                                    enterNation.countryPlayer.regions[i].divisions[currDiv].kilkRec += 1000;
                                }


                                enterNation.countryPlayer.regions[i].divisions[currDiv].ZagDam /= enterNation.countryPlayer.regions[i].divisions[currDiv].polks.Count;
                                enterNation.countryPlayer.regions[i].divisions[currDiv].ZagStep /= enterNation.countryPlayer.regions[i].divisions[currDiv].polks.Count;
                                enterNation.countryPlayer.regions[i].divisions[currDiv].ZagBr /= enterNation.countryPlayer.regions[i].divisions[currDiv].polks.Count;
                                enterNation.countryPlayer.regions[i].divisions[currDiv].ZagHit /= enterNation.countryPlayer.regions[i].divisions[currDiv].polks.Count;
                            }

                        }
                    }

                    //Nazi
                    //Anclus
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism && skipTurn.Time.Year == 1937)
                    {
                        Ancluss.gameObject.SetActive(true);
                    }

                    //MunichZrada
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism && skipTurn.Time.Year == 1937 && skipTurn.Time.Month == 11)
                    {
                        MunichZrada.gameObject.SetActive(true);
                    }

                    //SudbaChech
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism && skipTurn.Time.Year == 1938)
                    {
                        SudbaChech.gameObject.SetActive(true);
                    }

                    //Poland
                    if (enterNation.countryPlayer.idelogy == Idelogies.Fascism && skipTurn.Time.Year == 1939)
                    {
                        PolandW.gameObject.SetActive(true);
                    }
                }

            }
            else
            {

            }
        }
    }
}