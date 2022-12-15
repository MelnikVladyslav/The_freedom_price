using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class RichenyaMechanics : MonoBehaviour
    {
        public EnterNation enterNation;
        public int ballDem = 0;
        public int ballNeu = 0;
        public int ballcom = 0;
        public int ballFac = 0;
        public int ballNac = 0;
        public int ballMon = 0;
        public Text ProcPP;
        public Text ProcOP;

        public void PidtDem()
        {
            ballDem++;
        }
        public void PidtNeu()
        {
            ballNeu++;
        }
        public void Pidtcom()
        {
            ballcom++;
        }
        public void PidtFac()
        {
            ballFac++;
        }
        public void PidtNac()
        {
            ballNac++;
        }
        public void PidtMon()
        {
            ballMon++;
        }
    }
}