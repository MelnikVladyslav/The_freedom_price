using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class CountryMechanics : MonoBehaviour
    {
        public EnterNation enterNation;
        public StartScriptsInitilazer start;
        public Text CountryName;
        public Text Podatku;
        public Text ProcentViyskov;
        public Text Recriut;
        public Text NameIdeol;
        public Text ProcPP;
        public Text ProcOP;
        public int procPod = 50;

        // Use this for initialization
        void Start()
        {
            CountryName.text = enterNation.countryPlayer.Name;
            if (Podatku != null)
            {
                Podatku.text = procPod.ToString() + "%";
            }
            if (ProcentViyskov != null)
            {
                ProcentViyskov.text = enterNation.countryPlayer.ProcentViyskovoZob.ToString() + "%";
            }
            if (NameIdeol != null)
            {
                NameIdeol.text = enterNation.countryPlayer.idelogy.ToString();
            }
            if (ProcPP != null)
            {
                ProcPP.text = enterNation.countryPlayer.Popularity.ToString() + "%";
            }
            if (ProcOP != null)
            {
                ProcOP.text = (100 - enterNation.countryPlayer.Popularity).ToString() + "%";
            }
        }

        public void PlusPod()
        {
            procPod += 1;
            enterNation.countryPlayer.Popularity -= 1;
            if (Podatku != null)
            {
                Podatku.text = procPod.ToString() + "%";
                ProcPP.text = enterNation.countryPlayer.Popularity.ToString() + "%";
                ProcOP.text = (100 - enterNation.countryPlayer.Popularity).ToString() + "%";

            }
        }

        public void PlusViys()
        {
            if (enterNation.countryPlayer.ProcentViyskovoZob != 0)
            {
                enterNation.countryPlayer.ProcentViyskovoZob += 1;
                enterNation.countryPlayer.Popularity -= 1;
            }
            if (start != null)
            {
                enterNation.countryPlayer.KilkistyRecruit = enterNation.countryPlayer.PopulationCount / (100 / enterNation.countryPlayer.ProcentViyskovoZob) - start.kilkNayn;
            }
            if (Podatku != null)
            {
                ProcentViyskov.text = enterNation.countryPlayer.ProcentViyskovoZob.ToString() + "%";
                Recriut.text = enterNation.countryPlayer.KilkistyRecruit.ToString();
                ProcPP.text = enterNation.countryPlayer.Popularity.ToString() + "%";
                ProcOP.text = (100 - enterNation.countryPlayer.Popularity).ToString() + "%";
            }
        }

        public void MinusPod()
        {
            procPod -= 1;
            enterNation.countryPlayer.Popularity += 1;
            if (Podatku != null)
            {
                Podatku.text = procPod.ToString() + "%";
                ProcPP.text = enterNation.countryPlayer.Popularity.ToString() + "%";
                ProcOP.text = (100 - enterNation.countryPlayer.Popularity).ToString() + "%";
            }
        }

        public void MinusViys()
        {
            if (enterNation.countryPlayer.ProcentViyskovoZob != 0)
            {
                enterNation.countryPlayer.ProcentViyskovoZob -= 1;
                enterNation.countryPlayer.Popularity += 1;
            }
            if (start != null)
            {
                enterNation.countryPlayer.KilkistyRecruit = enterNation.countryPlayer.PopulationCount / (100 / enterNation.countryPlayer.ProcentViyskovoZob) - start.kilkNayn;
            }
            if (Podatku != null)
            {
                ProcentViyskov.text = enterNation.countryPlayer.ProcentViyskovoZob.ToString() + "%";
                Recriut.text = enterNation.countryPlayer.KilkistyRecruit.ToString();
                ProcPP.text = enterNation.countryPlayer.Popularity.ToString() + "%";
                ProcOP.text = (100 - enterNation.countryPlayer.Popularity).ToString() + "%";
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}