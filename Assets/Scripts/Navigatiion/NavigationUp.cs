using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class NavigationUp : MonoBehaviour
    {
        public EnterNation enterNation;
        public RawImage Flag;
        public Text TextStab;
        public Text TextRecriut;
        public Text TextMoney;
        public Text TextBuilsRes;
        public Text TextStail;
        public Text TextTopluvo;
        public Text TextKauchuk;

        // Use this for initialization
        void Start()
        {
            if (true)
            {
                Flag.texture = enterNation.countryPlayer.Flag;
                TextStab.text = enterNation.countryPlayer.Stabilnisty.ToString() + "%";
                TextRecriut.text = enterNation.countryPlayer.KilkistyRecruit.ToString();
                TextMoney.text = enterNation.countryPlayer.Money.ToString();
                TextBuilsRes.text = enterNation.countryPlayer.BuildResourse.ToString();
                TextStail.text = enterNation.countryPlayer.Stail.ToString();
                TextTopluvo.text = enterNation.countryPlayer.Topluvo.ToString();
                TextKauchuk.text = enterNation.countryPlayer.Kauchuk.ToString();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (true)
            {
                Flag.texture = enterNation.countryPlayer.Flag;
                TextStab.text = enterNation.countryPlayer.Stabilnisty.ToString() + "%";
                TextRecriut.text = enterNation.countryPlayer.KilkistyRecruit.ToString();
                TextMoney.text = enterNation.countryPlayer.Money.ToString();
                TextBuilsRes.text = enterNation.countryPlayer.BuildResourse.ToString();
                TextStail.text = enterNation.countryPlayer.Stail.ToString();
                TextTopluvo.text = enterNation.countryPlayer.Topluvo.ToString();
                TextKauchuk.text = enterNation.countryPlayer.Kauchuk.ToString();
            }
        }
    }
}