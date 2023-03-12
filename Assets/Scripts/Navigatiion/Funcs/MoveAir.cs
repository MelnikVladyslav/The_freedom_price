using Assets.Class.Army;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class MoveAir : MonoBehaviour
    {
        public NavigationDown navigationDown;
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public StartScriptsInitilazer start;
        public InputField nameAir;
        public InputField nameReg;
        public Text listsAir;
        public Text listRegs;
        public Text resultAir;
        public Text resultReg;
        public int idReg;
        public int idAir;
        public int idEndRegion;

        public void Start()
        {
            idReg = navigationDown.idRegion;

            listRegs.text = "";
            listsAir.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].airs.Count; i++)
            {
                listsAir.text += enterNation.countryPlayer.regions[navigationDown.idRegion].airs[i].Name + "\n";
            }
        }

        public void FindAir()
        {
            resultAir.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].airs.Count; i++)
            {
                if (enterNation.countryPlayer.regions[navigationDown.idRegion].airs[i].Name == nameAir.text)
                {
                    idAir = i;
                    resultAir.text += "Air found";
                }
            }
        }

        public void FindReg()
        {
            resultReg.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                if (enterNation.countryPlayer.regions[i].Name == nameReg.text)
                {
                    idEndRegion = i;
                    resultReg.text += "Region found";
                }
            }
        }

        public void Moves()
        {
            resultAir.text = "";
            int vidstany = (int)Math.Pow(Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.x - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.x), 2.0) + Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.y - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.y), 2.0), 0.5);

            if (vidstany < 0)
            {
                vidstany *= -1;
            }
            else if (idEndRegion == navigationDown.idRegion)
            {
                vidstany = 0;
            }
            else if (vidstany > 5)
            {
                vidstany /= enterNation.countryPlayer.regions[idReg].airs[idAir].Step;
            }

            MoveAirClass moved =
                new MoveAirClass()
                {
                    movedAir = enterNation.countryPlayer.regions[idReg].airs[idAir],
                    idStartReg = idReg,
                    idEndReg = idEndRegion,
                    kilkTurns = vidstany
                };

            skipTurn.listMovedAir.Add(moved);

            enterNation.countryPlayer.regions[idReg].airs.Remove(enterNation.countryPlayer.regions[idReg].airs[idAir]);

            resultAir.text = "Kilkisty turns for move: " + vidstany;
        }

        public void Update()
        {

            listRegs.text = "";
            listsAir.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].airs.Count; i++)
            {
                listsAir.text += enterNation.countryPlayer.regions[navigationDown.idRegion].airs[i].Name + "\n";
            }

            for (int i = 0; i < start.CountryList.Count; i++)
            {
                if (start.CountryList[i].Types == TypeCountry.Enemy)
                {
                    for (int j = 0; j < start.CountryList[i].regions.Count; j++)
                    {
                        listRegs.text += start.CountryList[i].regions[j].Name + "\n";
                    }
                }
            }
        }
    }
}