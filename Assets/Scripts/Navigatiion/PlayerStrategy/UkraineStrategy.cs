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
        public GameObject SystemDem;
        public GameObject EnterAlianceWithBr;
        public Text infoText;
        public RawImage fotoIventResVub;
        public List<Texture> listFlagsForIdeol;
        public Camera mainCamera;
        public GameObject WarMonVssssr;
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
        bool isOkAlBr = false;
        bool isRevDem = false;
        Vector3 positionCapital;
        GameObject capital;

        // Use this for initialization
        void Start()
        {

        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "Soborna Ukraine" || enterNation.countryPlayer.Name == "Ukraine" || enterNation.countryPlayer.Name == "ursr") 
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

        //System democrate
        public void EnterDemToPower()
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

            ResultVub.gameObject.SetActive(true);

            SystemDem.gameObject.SetActive(false);

        }

        public void EnterRevDem()
        {
            isRevDem = true;

            SystemDem.gameObject.SetActive(false);
        }

        public void OkBrit()
        {
            isOkAlBr = true;

            EnterAlianceWithBr.gameObject.SetActive(false);
        }

        //System Monarchy
        public void Warsssr()
        {
            start.CountryList[8].Types = TypeCountry.Enemy;
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
                    Golosuvanya.gameObject.SetActive(true);
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
                            if (start.CountryList[0].NameAlliens == "Axis")
                            {
                                start.CountryList[1].NameAlliens = "Axis";
                                start.CountryList[0].Types = TypeCountry.Alliens;
                            }
                        }

                        if (kilkBalFac >= 6)
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

                            ResultVub.gameObject.SetActive(true);
                        }
                    }

                    //System democrate
                    if (kilkBalDem >= 3)
                    {
                        if (!isRevDem)
                        {
                            SystemDem.gameObject.SetActive(true);
                        }

                        if (isRevDem)
                        {
                            int idNewCoun = 0;
                            start.CountryList.Add(new Country()
                            {
                                Name = "Ukraine",
                                idelogy = Idelogies.Democraty,
                                Popularity = 60,
                                Flag = listFlagsForIdeol[4]
                            });

                            //Initilize lider
                            for (int i = 0; i < start.liderList.Count; i++)
                            {
                                for (int j = 0; j < start.CountryList.Count; j++)
                                {
                                    if (start.liderList[i].country.Name == start.CountryList[j].Name)
                                    {
                                        if (start.liderList[i].idelogies == start.CountryList[j].idelogy)
                                        {
                                            start.CountryList[j].currentLider = start.liderList[i];
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < start.CountryList.Count; i++)
                            {
                                if (start.CountryList[i].Name == "Ukraine")
                                {
                                    idNewCoun = i;
                                }
                            }

                            start.CountryList[idNewCoun].regions.Add(start.RegionList[18]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[19]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[20]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[22]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[23]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[24]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[25]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[26]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[27]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[28]);

                            start.CountryList[1].regions.Remove(start.RegionList[18]);
                            start.CountryList[1].regions.Remove(start.RegionList[19]);
                            start.CountryList[1].regions.Remove(start.RegionList[20]);
                            start.CountryList[1].regions.Remove(start.RegionList[22]);
                            start.CountryList[1].regions.Remove(start.RegionList[23]);
                            start.CountryList[1].regions.Remove(start.RegionList[24]);
                            start.CountryList[1].regions.Remove(start.RegionList[25]);
                            start.CountryList[1].regions.Remove(start.RegionList[26]);
                            start.CountryList[1].regions.Remove(start.RegionList[27]);
                            start.CountryList[1].regions.Remove(start.RegionList[28]);

                            enterNation.countryPlayer = start.CountryList[idNewCoun];
                            start.CountryList[idNewCoun].Types = TypeCountry.Player;
                            start.CountryList[1].Types = TypeCountry.Enemy;

                            for (int i = 0; i < start.liderList.Count; i++)
                            {
                                if (i <= 5)
                                {
                                    start.liderList[i].country = start.CountryList[idNewCoun];
                                }
                            }

                            capital = start.CountryList[1].regions[0].town;

                            positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                            mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                            start.InitilizerCountry();

                        }
                    }

                    if (enterNation.countryPlayer.idelogy == Idelogies.Democraty)
                    {
                        if (enterNation.countryPlayer.NameAlliens == "" && !isOkAlBr)
                        {
                            EnterAlianceWithBr.gameObject.SetActive(true);
                        }
                        if (start.CountryList[20].NameAlliens == "" && isOkAlBr == true)
                        {
                            start.CountryList[20].NameAlliens = "Aliance";
                            enterNation.countryPlayer.NameAlliens = "Aliance";
                            start.CountryList[20].Types = TypeCountry.Alliens;
                        }
                        if (start.CountryList[20].NameAlliens == "Aliance" && isOkAlBr == true)
                        {
                            enterNation.countryPlayer.NameAlliens = "Aliance";
                            start.CountryList[20].Types = TypeCountry.Alliens;
                        }
                    }

                    //System cummunism
                    if (kilkBalCom >= 3)
                    {
                        enterNation.countryPlayer.Stabilnisty -= 10;

                        if (enterNation.countryPlayer.Stabilnisty <= 30)
                        {
                            int idNewCoun = 0;
                            start.CountryList.Add(new Country()
                            {
                                Name = "ursr",
                                idelogy = Idelogies.Communism,
                                Popularity = 60,
                                Flag = listFlagsForIdeol[2]
                            });

                            //Initilize lider
                            for (int i = 0; i < start.liderList.Count; i++)
                            {
                                for (int j = 0; j < start.CountryList.Count; j++)
                                {
                                    if (start.liderList[i].country.Name == start.CountryList[j].Name)
                                    {
                                        if (start.liderList[i].idelogies == start.CountryList[j].idelogy)
                                        {
                                            start.CountryList[j].currentLider = start.liderList[i];
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < start.CountryList.Count; i++)
                            {
                                if (start.CountryList[i].Name == "ursr")
                                {
                                    idNewCoun = i;
                                }
                            }

                            start.CountryList[idNewCoun].regions.Add(start.RegionList[33]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[34]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[35]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[36]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[37]);
                            start.CountryList[idNewCoun].regions.Add(start.RegionList[38]);

                            start.CountryList[1].regions.Remove(start.RegionList[33]);
                            start.CountryList[1].regions.Remove(start.RegionList[34]);
                            start.CountryList[1].regions.Remove(start.RegionList[35]);
                            start.CountryList[1].regions.Remove(start.RegionList[36]);
                            start.CountryList[1].regions.Remove(start.RegionList[37]);

                            enterNation.countryPlayer = start.CountryList[idNewCoun];
                            start.CountryList[idNewCoun].Types = TypeCountry.Player;
                            start.CountryList[1].Types = TypeCountry.Enemy;

                            for (int i = 0; i < start.liderList.Count; i++)
                            {
                                if (i <= 5)
                                {
                                    start.liderList[i].country = start.CountryList[idNewCoun];
                                }
                            }

                            capital = start.CountryList[1].regions[0].town;

                            positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                            mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                            start.CountryList[8].Types = TypeCountry.Alliens;
                        }

                        start.InitilizerCountry();
                    }

                    //System monarchy
                    if (kilkBalMon >= 3)
                    {
                        if (enterNation.countryPlayer.idelogy != Idelogies.Monarchy)
                        {
                            enterNation.countryPlayer.Popularity -= 5;
                        }

                        kilkBalNat = 0;
                    }

                    if (enterNation.countryPlayer.idelogy == Idelogies.Monarchy && skipTurn.Time.Year == 1942)
                    {
                        WarMonVssssr.gameObject.SetActive(true);
                    }

                    //System anarchy
                    if (kilkBalAna >= 3)
                    {
                        int idNewCoun = 0;
                        start.CountryList.Add(new Country()
                        {
                            Name = "Ukraine",
                            idelogy = Idelogies.Anarchy,
                            Popularity = 60,
                            Flag = listFlagsForIdeol[1]
                        });

                        //Initilize lider
                        for (int i = 0; i < start.liderList.Count; i++)
                        {
                            for (int j = 0; j < start.CountryList.Count; j++)
                            {
                                if (start.liderList[i].country.Name == start.CountryList[j].Name)
                                {
                                    if (start.liderList[i].idelogies == start.CountryList[j].idelogy)
                                    {
                                        start.CountryList[j].currentLider = start.liderList[i];
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < start.CountryList.Count; i++)
                        {
                            if (start.CountryList[i].Name == "Ukraine")
                            {
                                idNewCoun = i;
                            }
                        }

                        start.CountryList[idNewCoun].regions.Add(start.RegionList[16]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[17]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[18]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[19]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[20]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[21]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[22]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[23]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[35]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[36]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[37]);
                        start.CountryList[idNewCoun].regions.Add(start.RegionList[38]);

                        start.CountryList[1].regions.Remove(start.RegionList[16]);
                        start.CountryList[1].regions.Remove(start.RegionList[17]);
                        start.CountryList[1].regions.Remove(start.RegionList[18]);
                        start.CountryList[1].regions.Remove(start.RegionList[19]);
                        start.CountryList[1].regions.Remove(start.RegionList[20]);
                        start.CountryList[1].regions.Remove(start.RegionList[21]);
                        start.CountryList[1].regions.Remove(start.RegionList[22]);
                        start.CountryList[1].regions.Remove(start.RegionList[23]);
                        start.CountryList[1].regions.Remove(start.RegionList[35]);
                        start.CountryList[1].regions.Remove(start.RegionList[36]);
                        start.CountryList[1].regions.Remove(start.RegionList[37]);
                        start.CountryList[1].regions.Remove(start.RegionList[38]);

                        start.CountryList[1].regions.Remove(start.RegionList[34]);

                        start.CountryList[8].regions.Add(start.RegionList[34]);

                        enterNation.countryPlayer = start.CountryList[idNewCoun];
                        start.CountryList[idNewCoun].Types = TypeCountry.Player;
                        start.CountryList[1].Types = TypeCountry.Enemy;

                        for (int i = 0; i < start.liderList.Count; i++)
                        {
                            if (i <= 5)
                            {
                                start.liderList[i].country = start.CountryList[idNewCoun];
                            }
                        }

                        capital = start.CountryList[1].regions[0].town;

                        positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                        mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                        start.InitilizerCountry();
                    }
                }
            }
            else
            {

            }
        }
    }
}