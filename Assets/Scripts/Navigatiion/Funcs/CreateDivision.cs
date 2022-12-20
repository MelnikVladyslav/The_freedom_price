using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class CreateDivision : MonoBehaviour
    {
        public EnterNation enterNation;
        public StartScriptsInitilazer start;
        public InputField nameDiv;
        public Text info;
        public List<RawImage> icons = new List<RawImage>();
        public InputField namePolk;
        public Text listsPolks; 
        public Text divisionsName;
        Polk currentPolk;
        Division currentShablon;
        int currentId;

        void Start()
        {
            currentShablon = new Division();
            for (int j = 0; j < enterNation.countryPlayer.techs.Count; j++)
            {
                if (enterNation.countryPlayer.techs[j].polks != null)
                {
                    for (int a = 0; a < enterNation.countryPlayer.techs[j].polks.Count; a++)
                    {
                        listsPolks.text += enterNation.countryPlayer.techs[j].polks[a].Name + "\n";
                    }
                }
                else
                {
                    break;
                }
            }
            info.text = "Hit: " + "\n" + "Damage: " + "\n" + "Step: " + "\n" + "Bronya: " + "\n" + "Price: " + "\n" + "Kilkisty recriut: ";
        }

        public void EnterPolk()
        {
            for (int i = 0; i < start.PolkList.Count; i++)
            {
                if (namePolk.text == start.PolkList[i].Name)
                {
                    currentPolk = start.PolkList[i];
                    icons[currentId].texture = start.PolkList[i].icon;
                }
            }

            currentShablon.polks.Add(currentPolk);

            if (currentShablon.polks[0] != null)
            {
                currentShablon.ZagDam = 0;
                currentShablon.ZagStep = 0;
                currentShablon.ZagBr = 0;
                currentShablon.ZagHit = 0;
                currentShablon.Price = 0;
                currentShablon.kilkRec = 0;
                for (int i = 0; i < currentShablon.polks.Count; i++)
                {
                    currentShablon.ZagDam += currentShablon.polks[i].Damage;
                    currentShablon.ZagStep += currentShablon.polks[i].Step;
                    currentShablon.ZagBr += currentShablon.polks[i].Bronya;
                    currentShablon.ZagHit += currentShablon.polks[i].Hit;
                    currentShablon.Price += currentShablon.polks[i].Price;
                    currentShablon.kilkRec += 1000;
                }

                currentShablon.ZagDam /= currentShablon.polks.Count;
                currentShablon.ZagStep /= currentShablon.polks.Count;
                currentShablon.ZagBr /= currentShablon.polks.Count;
                currentShablon.ZagHit /= currentShablon.polks.Count;
            }

            info.text = "Hit: " + currentShablon.ZagHit + "\n" + "Damage: " + currentShablon.ZagDam + "\n" + "Step: " + currentShablon.ZagStep + "\n" + "Bronya: " + currentShablon.ZagBr + "\n" + "Price: " + currentShablon.Price + "\n" + "Kilkisty recriut: " + currentShablon.kilkRec;

        }

        public void AddPolk(int id)
        {
            currentId = id;
        }

        public void Create()
        {
            currentShablon.Name = nameDiv.text;

            enterNation.countryPlayer.shablons.Add(currentShablon);

            if (enterNation.countryPlayer.shablons != null)
            {
                divisionsName.text = "";

                for (int i = 0; i < enterNation.countryPlayer.shablons.Count; i++)
                {
                    divisionsName.text += enterNation.countryPlayer.shablons[i].Name + "\n";
                }
            }

            currentShablon = new Division();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}