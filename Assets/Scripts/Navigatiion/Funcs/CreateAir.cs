using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class CreateAir : MonoBehaviour
    {
        public EnterNation enterNation;
        public NavigationDown navigationDown;
        public StartScriptsInitilazer start;
        public SkipTurn skipTurn;
        public Text listsAirs;
        public Text infoair;
        public InputField nameAir;
        public int idRegion;
        public int idAir;

        // Use this for initialization
        void Start()
        {
            idRegion = navigationDown.idRegion;

            for (int i = 0; i < start.AirList.Count; i++)
            {
                listsAirs.text += start.AirList[i].Name + "\n";
            }
        }

        public void FindAir()
        {
            infoair.text = "";

            for (int i = 0; i < start.AirList.Count; i++)
            {
                if (start.AirList[i].Name == nameAir.text)
                {
                    idAir = i;
                    infoair.text += "Name: " + start.AirList[i].Name + "\n" + "Hit: " + start.AirList[i].Hit + "\n" + "Damage: " + start.AirList[i].Damage + "\n" + "Step: " + start.AirList[i].Step + "\n" + "Price: " + start.AirList[i].Price + "\n";    
                }
            }
        }

        public void Create()
        {
            if (enterNation.countryPlayer.Money >= start.AirList[idAir].Price)
            {
                enterNation.countryPlayer.Money -= start.AirList[idAir].Price;
                enterNation.countryPlayer.Topluvo -= 100;

                skipTurn.currentAir.Name = start.AirList[idAir].Name;
                skipTurn.currentAir.Hit = start.AirList[idAir].Hit;
                skipTurn.currentAir.Damage = start.AirList[idAir].Damage;
                skipTurn.currentAir.Type = start.AirList[idAir].Type;
                skipTurn.currentAir.Step = start.AirList[idAir].Step;
                skipTurn.currentAir.Price = start.AirList[idAir].Price;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}