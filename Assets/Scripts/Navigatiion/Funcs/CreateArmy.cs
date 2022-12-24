using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class CreateArmy : MonoBehaviour
    {
        public NavigationDown navigationDown;
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public Text listsDivisions;
        public Text infoDivison;
        public InputField nameDiv;
        int idDiv = 0;
        public int idRegion = 0;

        public void Start()
        {
            idRegion = navigationDown.idRegion;

            for (int i = 0; i < enterNation.countryPlayer.shablons.Count; i++)
            {
                listsDivisions.text += enterNation.countryPlayer.shablons[i].Name + "\n";
            }
        }

        public void FindDiv()
        {
            for (int i = 0; i < enterNation.countryPlayer.shablons.Count; i++)
            {
                if (enterNation.countryPlayer.shablons[i].Name == nameDiv.text)
                {
                    idDiv = i;
                    infoDivison.text = "Hit: " + enterNation.countryPlayer.shablons[i].ZagHit + "\n" + "Damage: " + enterNation.countryPlayer.shablons[i].ZagDam + "\n" + "Step: " + enterNation.countryPlayer.shablons[i].ZagStep + "\n" + "Bronya: " + enterNation.countryPlayer.shablons[i].ZagBr + "\n" + "Price: " + enterNation.countryPlayer.shablons[i].Price + "\n" + "Kilkisty recriut: " + enterNation.countryPlayer.shablons[i].kilkRec;
                }
            }
        }

        public void Create()
        {
            int kilkArt = 0;
            int kilkBtr = 0;
            int kilkMot = 0;
            int kilkTanks = 0;
            int priceStail = 0;
            int priceTopluvo = 0;
            int priceKauchuk = 0;

            for (int i = 0; i < enterNation.countryPlayer.shablons[idDiv].polks.Count; i++)
            {
                if (enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Artilery")
                {
                    kilkArt++;
                }
                if (enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Btr")
                {
                    kilkBtr++;
                }
                if (enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Motorized" || enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Mechanized")
                {
                    kilkMot++;
                }
                if (enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Light Tank" || enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Medium Tank" || enterNation.countryPlayer.shablons[idDiv].polks[i].Name == "Heavy Tank")
                {
                    kilkTanks++;
                }
            }

            if (kilkArt != 0)
            {
                priceStail += (enterNation.countryPlayer.shablons[idDiv].Price / 10 ) * kilkArt;
            }
            if (kilkBtr != 0)
            {
                priceStail += (enterNation.countryPlayer.shablons[idDiv].Price / 10) * kilkBtr;
                priceTopluvo += enterNation.countryPlayer.shablons[idDiv].Price / kilkBtr;
            }
            if (kilkMot != 0)
            {
                priceStail += (enterNation.countryPlayer.shablons[idDiv].Price / 10) * kilkMot;
                priceTopluvo += enterNation.countryPlayer.shablons[idDiv].Price / kilkMot;
            }
            if (kilkTanks != 0)
            {
                priceStail += (enterNation.countryPlayer.shablons[idDiv].Price / 10) * kilkTanks;
                priceTopluvo += enterNation.countryPlayer.shablons[idDiv].Price / kilkTanks;
                priceKauchuk += (enterNation.countryPlayer.shablons[idDiv].Price / 20) * kilkTanks;
            }

            if (enterNation.countryPlayer.Money < enterNation.countryPlayer.shablons[idDiv].Price && enterNation.countryPlayer.Stail < priceStail && enterNation.countryPlayer.Topluvo < priceTopluvo && enterNation.countryPlayer.Kauchuk < priceKauchuk)
            {

            }
            else
            {
                skipTurn.currentDiv.Name = enterNation.countryPlayer.shablons[idDiv].Name;
                skipTurn.currentDiv.Price = enterNation.countryPlayer.shablons[idDiv].Price;
                skipTurn.currentDiv.ZagDam = enterNation.countryPlayer.shablons[idDiv].ZagDam;
                skipTurn.currentDiv.ZagStep = enterNation.countryPlayer.shablons[idDiv].ZagStep;
                skipTurn.currentDiv.ZagBr = enterNation.countryPlayer.shablons[idDiv].ZagBr;
                skipTurn.currentDiv.ZagHit = enterNation.countryPlayer.shablons[idDiv].ZagHit;
                skipTurn.currentDiv.kilkRec = enterNation.countryPlayer.shablons[idDiv].kilkRec;
                skipTurn.currentDiv.kilkturns = 2;

                for (int i = 0; i < enterNation.countryPlayer.shablons[idDiv].polks.Count; i++)
                {
                    skipTurn.currentDiv.polks.Add(enterNation.countryPlayer.shablons[idDiv].polks[i]);
                }

                enterNation.countryPlayer.Money -= enterNation.countryPlayer.shablons[idDiv].Price;
                enterNation.countryPlayer.Stail -= priceStail;
                enterNation.countryPlayer.Topluvo -= priceTopluvo;
                enterNation.countryPlayer.Kauchuk -= priceKauchuk;
            }
        }
    }
}