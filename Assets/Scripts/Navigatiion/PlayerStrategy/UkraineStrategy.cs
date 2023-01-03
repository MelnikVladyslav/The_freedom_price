using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Navigatiion.PlayerStrategy
{
    public class UkraineStrategy : MonoBehaviour
    {
        public EnterNation enterNation;

        // Use this for initialization
        void Start()
        {
            bool isPlayer = Perevirka();

            if (isPlayer == true)
            {

            }
            else
            {
                Debug.Log("Is ai");
            }
        }

        public bool Perevirka()
        {
            if (enterNation.countryPlayer.Name == "Soborna Ukraine")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}