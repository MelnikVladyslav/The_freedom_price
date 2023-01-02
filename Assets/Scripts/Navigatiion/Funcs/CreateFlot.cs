using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class CreateFlot : MonoBehaviour
    {
        public EnterNation enterNation;
        public NavigationDown navigationDown;
        public StartScriptsInitilazer start;
        public SkipTurn skipTurn;
        public Text listsFlots;
        public Text infoFlot;
        public InputField nameFlot;
        public int idRegion;
        public int idFlot;

        // Use this for initialization
        void Start()
        {
            idRegion = navigationDown.idRegion;

            for (int i = 0; i < start.FlotList.Count; i++)
            {
                listsFlots.text += start.FlotList[i].Name + "\n";
            }
        }

        public void FindFlot()
        {
            infoFlot.text = "";

            for (int i = 0; i < start.FlotList.Count; i++)
            {
                if (start.FlotList[i].Name == nameFlot.text)
                {
                    idFlot = i;
                    infoFlot.text += "Name: " + start.FlotList[i].Name + "\n" + "Hit: " + start.FlotList[i].Hit + "\n" + "Damage: " + start.FlotList[i].Damage + "\n" + "Bronya: " + start.FlotList[i].Bronya + "\n" + "Step: " + start.FlotList[i].Step + "\n" + "Price: " + start.FlotList[i].Price + "\n";
                }
            }
        }

        public void Create()
        {
            if (enterNation.countryPlayer.Money >= start.FlotList[idFlot].Price)
            {
                enterNation.countryPlayer.Money -= start.FlotList[idFlot].Price;
                enterNation.countryPlayer.Stail -= start.FlotList[idFlot].Price / 2;
                enterNation.countryPlayer.Topluvo -= 100;

                skipTurn.currentFlot.Name = start.FlotList[idFlot].Name;
                skipTurn.currentFlot.Hit = start.FlotList[idFlot].Hit;
                skipTurn.currentFlot.Damage = start.FlotList[idFlot].Damage;
                skipTurn.currentFlot.Bronya = start.FlotList[idFlot].Bronya;
                skipTurn.currentFlot.Type = start.FlotList[idFlot].Type;
                skipTurn.currentFlot.Step = start.FlotList[idFlot].Step;
                skipTurn.currentFlot.Price = start.FlotList[idFlot].Price;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}