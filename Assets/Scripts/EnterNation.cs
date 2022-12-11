using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnterNation : MonoBehaviour
    {
        Vector3 positionCapital;
        public Camera mainCamera;
        public StartScriptsInitilazer startScripts;
        GameObject capital;

        public void EnterUpa()
        {
            if (startScripts.CountryList[1].regions != null)
            {
                capital = startScripts.CountryList[1].regions[0].town;

                positionCapital = new Vector3(capital.transform.position.x, capital.transform.position.y);

                mainCamera.transform.position = new Vector3(positionCapital.x, positionCapital.y);
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
            }
            else
            {
                Debug.Log("Not capital");
            }
        }
    }
}