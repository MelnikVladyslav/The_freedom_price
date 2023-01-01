using Assets.Class.Army;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class Move : MonoBehaviour
    {
        public NavigationDown navigationDown;
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public InputField nameDiv;
        public InputField nameReg;
        public Text listsDiv;
        public Text listRegs;
        public Text resultDiv;
        public Text resultReg;
        public int idReg;
        public int idDiv;
        public int idEndRegion;

        public void Start()
        {
            idReg = navigationDown.idRegion;

            listRegs.text = "";
            listsDiv.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].divisions.Count; i++)
            {
                listsDiv.text += enterNation.countryPlayer.regions[navigationDown.idRegion].divisions[i].Name + "\n";
            }
        }

        public void FindDiv()
        {
            resultDiv.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].divisions.Count; i++)
            {
                if (enterNation.countryPlayer.regions[navigationDown.idRegion].divisions[i].Name == nameDiv.text)
                {
                    idDiv = i;
                    resultDiv.text += "Division found";
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
            resultDiv.text = "";
            int vidstany = (int)Math.Pow(Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.x - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.x), 2.0) + Math.Pow((enterNation.countryPlayer.regions[idEndRegion].town.transform.position.y - enterNation.countryPlayer.regions[navigationDown.idRegion].town.transform.position.y), 2.0), 0.5);

            if (vidstany < 0)
            {
                vidstany *= -1;
            }
            else  if(idEndRegion == navigationDown.idRegion)
            {
                vidstany = 0;
            }
            else if (vidstany > 1)
            {
                vidstany /= enterNation.countryPlayer.regions[idReg].divisions[idDiv].ZagStep;
            }

            skipTurn.listMovedDiv.Add(
                new MoveDivisionClass()
                {
                    movedDiv = enterNation.countryPlayer.regions[idReg].divisions[idDiv],
                    idStartReg = idReg,
                    idEndReg = idEndRegion,
                    kilkTurns = vidstany
                }
            );

            enterNation.countryPlayer.regions[idReg].divisions.Remove(enterNation.countryPlayer.regions[idReg].divisions[idDiv]);

            resultDiv.text = "Kilkisty turns for move: " + vidstany;
        }

        public void Update()
        {

            listRegs.text = "";
            listsDiv.text = "";

            for (int i = 0; i < enterNation.countryPlayer.regions.Count; i++)
            {
                listRegs.text += enterNation.countryPlayer.regions[i].Name + "\n";
            }

            for (int i = 0; i < enterNation.countryPlayer.regions[navigationDown.idRegion].divisions.Count; i++)
            {
                listsDiv.text += enterNation.countryPlayer.regions[navigationDown.idRegion].divisions[i].Name + "\n";
            }
        }
    }
}