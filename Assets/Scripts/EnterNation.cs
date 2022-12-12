using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Assets.Scripts
{
    public class EnterNation : MonoBehaviour
    {
        Vector3 positionCapital;
        public Camera mainCamera;
        public StartScriptsInitilazer startScripts;
        GameObject capital;
        public Country countryPlayer;

        public void EnterUpa()
        {
            if (startScripts.CountryList[1].regions != null)
            {
                capital = startScripts.CountryList[1].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);

                countryPlayer = startScripts.CountryList[1];

                countryPlayer.Types = TypeCountry.Player;
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
            }
            else
            {
                Debug.Log("Not capital");
            }
        }
    }
}