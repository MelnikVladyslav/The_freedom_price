using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class EnterNation : MonoBehaviour
    {
        public Vector3 positionCapital;
        public Camera mainCamera;
        public StartScriptsInitilazer startScripts;
        GameObject capital;
        public Country countryPlayer;
        public Text countryParametrs;
        public int plusStab = 0;
        public int atack = 0;
        public int def = 0;

        public void EnterUpa()
        {
            if (startScripts.CountryList[1].regions != null)
            {
                capital = startScripts.CountryList[1].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[1];

                countryPlayer.Types = TypeCountry.Player;

                plusStab = 10;
                atack = 10;
                def = 10;

                countryParametrs.text = "Patriotic education: \n" + "Plus stabilnisty - " + plusStab + "\n Negative for enmies: \n" + "Attack vs Poland and sssr - " + atack + "\n" + "Defence vs Poland and sssr - " + def;

                countryPlayer.Stabilnisty += plusStab;
            }
            else
            {
                Debug.Log("Not capital");
            }
        }

        public void EnterReich()
        {
            if (startScripts.CountryList[0].regions != null)
            {
                capital = startScripts.CountryList[0].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[0];

                countryPlayer.Types = TypeCountry.Player;

                plusStab = 10;
                atack = 10;
                def = 10;

                countryParametrs.text = "Propaganda: \n" + "Plus stabilnisty - " + plusStab + "\n Germany genhtab: \n" + "Attack  - " + atack + "\n" + "Defence  - " + def;

                countryPlayer.Stabilnisty += plusStab;
                for (int i = 0; i < countryPlayer.openPolks.Count; i++)
                {
                    countryPlayer.openPolks[i].Damage += atack;
                    countryPlayer.openPolks[i].Bronya += def;
                }
            }
            else
            {
                Debug.Log("Not capital");
            }
        }

        public void Entersssr()
        {
            if (startScripts.CountryList[8].regions != null)
            {
                capital = startScripts.CountryList[8].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[8];

                countryPlayer.Types = TypeCountry.Player;

                atack = -10;
                def = -10;

                countryParametrs.text = "Old army: \n" + "Attack - " + atack + "\n" + "Defence - " + def;

                for (int i = 0; i < countryPlayer.openPolks.Count; i++)
                {
                    countryPlayer.openPolks[i].Damage += atack;
                    countryPlayer.openPolks[i].Bronya += def;
                }
            }
            else
            {
                Debug.Log("Not capital");
            }
        }

        public void EnterPoland()
        {
            if (startScripts.CountryList[9].regions != null)
            {
                capital = startScripts.CountryList[9].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[9];

                countryPlayer.Types = TypeCountry.Player;

                startScripts.CountryList[29].Types = TypeCountry.Marionetka;

                plusStab = -10;

                countryParametrs.text = "Two Poland: \n" + "Plus stabilnisty - " + plusStab;

                countryPlayer.Stabilnisty += plusStab;

            }
            else
            {
                Debug.Log("Not capital");
            }
        }

        public void EnterRumunia()
        {
            if (startScripts.CountryList[7].regions != null)
            {
                capital = startScripts.CountryList[7].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[7];

                countryPlayer.Types = TypeCountry.Player;

                plusStab = 10;

                countryParametrs.text = "Stabilna politic: \n" + "Plus stabilnisty - " + plusStab;

                countryPlayer.Stabilnisty += plusStab;
            }
            else
            {
                Debug.Log("Not capital");
            }
        }
    }
}