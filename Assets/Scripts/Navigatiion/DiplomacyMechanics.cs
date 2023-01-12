using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class DiplomacyMechanics : MonoBehaviour
    {
        public StartScriptsInitilazer start;
        public EnterNation enterNation;
        public InputField nameCountry;
        public Text listCoun;
        public RawImage Flag;
        public Text NameCountry;
        public GameObject Diplom;
        public Button enterWar;
        public Button enterAliance;
        public Button enterVasal;
        public Button enterTorg;
        int idCountry = 0;
        bool isWar = false;
        bool isAliance = false;
        bool isVasal = false;

        // Use this for initialization
        void Start()
        {
            listCoun.text += "";

            for (int i = 0; i < start.CountryList.Count; i++)
            {
                if (start.CountryList[i].Types != TypeCountry.Player)
                {
                    listCoun.text += start.CountryList[i].Name + "\n";
                }
            }
        }

        public void FindCoun()
        {
            for (int i = 0; i < start.CountryList.Count; i++)
            {
                if (start.CountryList[i].Types != TypeCountry.Player && start.CountryList[i].Name == nameCountry.text)
                {
                    Flag.texture = start.CountryList[i].Flag;
                    NameCountry.text = nameCountry.text;
                    idCountry = i;
                }
            }

            Diplom.gameObject.SetActive(true);

            if (start.CountryList[idCountry].Types != TypeCountry.Enemy)
            {
                isWar = true;

                enterWar.gameObject.SetActive(isWar);
            }
            else
            {
                isWar = true;

                enterWar.gameObject.SetActive(isWar);
            }
            if (start.CountryList[idCountry].Types != TypeCountry.Marionetka)
            {
                isVasal = true;

                enterVasal.gameObject.SetActive(isVasal);
            }
            else
            {
                isVasal = true;

                enterVasal.gameObject.SetActive(isVasal);
            }
            if (start.CountryList[idCountry].Types == TypeCountry.Alliens)
            {
                isAliance = false;

                enterAliance.gameObject.SetActive(isAliance);
            }
            else
            {
                isAliance = true;

                enterAliance.gameObject.SetActive(isAliance);
            }
        }

        public void EnterWar()
        {

            if (start.CountryList[idCountry].Types != TypeCountry.Enemy)
            {
                isWar = false;

                start.CountryList[idCountry].Types = TypeCountry.Enemy;

                enterWar.gameObject.SetActive(isWar);
            }
            else
            {
                isWar = true;

                enterWar.gameObject.SetActive(isWar);
            }
        }

        public void EnterAliance()
        {
            int isOk = Random.Range(0, 1);

            if (isOk == 1)
            {
                if (start.CountryList[idCountry].Types != TypeCountry.Alliens)
                {
                    isAliance = false;

                    start.CountryList[idCountry].Types = TypeCountry.Alliens;
                    start.CountryList[idCountry].NameAlliens = "MyAliance";
                    enterNation.countryPlayer.NameAlliens = "MyAliance";

                    enterAliance.gameObject.SetActive(isAliance);
                }
            }
            else
            {
                isAliance = true;

                enterAliance.gameObject.SetActive(isAliance);
            }
        }

        public void EnterVasal()
        {
            int isOk = Random.Range(0, 1);

            if (isOk == 1)
            {
                if (start.CountryList[idCountry].Types != TypeCountry.Marionetka)
                {
                    isVasal = false;

                    start.CountryList[idCountry].Types = TypeCountry.Marionetka;

                    enterVasal.gameObject.SetActive(isVasal);
                }
            }
            else
            {
                isVasal = true;

                enterVasal.gameObject.SetActive(isVasal);
            }
        }

        //Update is called once per frame
        void Update()
        {
            
        }
    }
}