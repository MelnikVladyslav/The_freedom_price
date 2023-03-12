using Assets.Class.Army;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class MoveFlot : MonoBehaviour
    {
        public NavigationDown navigationDown;
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public StartScriptsInitilazer start;
        public InputField nameFlot;
        public InputField nameReg;
        public Text listsFlot;
        public Text listRegs;
        public Text resultFlot;
        public Text resultReg;
        public int idReg;
        public int idFlot;
        public int idEndRegion;

        public void Start()
        {
            idReg = navigationDown.idRegion;

            listRegs.text = "";
            listsFlot.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya.Count; i++)
            {
                listsFlot.text += enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya[i].Name + "\n";
            }
        }

        public void FindFlot()
        {
            resultFlot.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya.Count; i++)
            {
                if (enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya[i].Name == nameFlot.text)
                {
                    idFlot = i;
                    resultFlot.text += "Flot found";
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
            resultFlot.text = "";
            int vidstany = (int)Math.Pow(Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.x - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.x), 2.0) + Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.y - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.y), 2.0), 0.5);

            if (vidstany < 0)
            {
                vidstany *= -1;
            }
            else if (idEndRegion == navigationDown.idRegion)
            {
                vidstany = 0;
            }

            MoveFlotClass moved =
                new MoveFlotClass()
                {
                    movedFlot = enterNation.countryPlayer.regions[idReg].flotiliya[idFlot],
                    idStartReg = idReg,
                    idEndReg = idEndRegion,
                    kilkTurns = vidstany
                };

            skipTurn.listMovedFlot.Add(moved);

            enterNation.countryPlayer.regions[idReg].flotiliya.Remove(enterNation.countryPlayer.regions[idReg].flotiliya[idFlot]);

            resultFlot.text = "Kilkisty turns for move: " + vidstany;
        }

        public void Update()
        {

            listRegs.text = "";
            listsFlot.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya.Count; i++)
            {
                listsFlot.text += enterNation.countryPlayer.regions[navigationDown.idRegion].flotiliya[i].Name + "\n";
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