using Assets.Scripts.Navigatiion;
using Assets.Scripts.Navigatiion.Funcs;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GeneratorbattleMap
{
    public class EnterTheTypeBatle : MonoBehaviour
    {
        public SkipTurn skip;
        public StartScriptsInitilazer start;
        public EnterNation enter;
        public int idMovedDiv;
        int kilkRecriut2 = 0;
        public Text NameBattle;
        public Text Info1;
        public Text Info2;
        public RawImage Flag1;
        public RawImage Flag2;
        public GameObject Army;
        public GameObject Win;

        // Use this for initialization
        void Start()
        {
            NameBattle.text = "Battle in " + start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].Name;
            for (int i = 0; i < start.CountryList.Count; i++)
            {
                for (int j = 0; j < start.CountryList[i].regions.Count; j++)
                {
                    if (start.CountryList[i].regions[j].Name == start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].Name)
                    {
                        Flag2.texture = start.CountryList[i].Flag;
                    }
                }
            }
            Flag1.texture = enter.countryPlayer.Flag;
            Info1.text = "Kilkisty recriut: " + skip.listMovedDiv[idMovedDiv].movedDiv.kilkRec.ToString();
            //Info2
            for (int i = 0; i < start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].divisions.Count; i++)
            {
                kilkRecriut2 += start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].divisions[i].kilkRec;
            }
            Info2.text = "Kilkisty recriut: " + kilkRecriut2;
        }

        public void StartBattle()
        {
            if (kilkRecriut2 == 0)
            {
                //Win.gameObject.SetActive(true); 
                //skip.start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].divisions.Add(skip.listMovedDiv[idMovedDiv].movedDiv);
                //skip.start.RegionList.Add(skip.start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg]);
                //skip.listMovedDiv.Remove(skip.listMovedDiv[idMovedDiv]);
                Army.gameObject.SetActive(true);

            }
            else
            {
                Army.gameObject.SetActive(true);
            }
        }

        // Update is called once per frame
        void Update()
        {
            NameBattle.text = "Battle in " + start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].Name;
            for (int i = 0; i < start.CountryList.Count; i++)
            {
                for (int j = 0; j < start.CountryList[i].regions.Count; j++)
                {
                    if (start.CountryList[i].regions[j].Name == start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].Name)
                    {
                        Flag2.texture = start.CountryList[i].Flag;
                    }
                }
            }
            Flag1.texture = enter.countryPlayer.Flag;
            Info1.text = "Kilkisty recriut: " + skip.listMovedDiv[idMovedDiv].movedDiv.kilkRec.ToString();
            //Info2
            int kilkRecriut2 = 0;
            for (int i = 0; i < start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].divisions.Count; i++)
            {
                kilkRecriut2 += start.RegionList[skip.listMovedDiv[idMovedDiv].idEndReg].divisions[i].kilkRec;
            }
            Info2.text = "Kilkisty recriut: " + kilkRecriut2;
        }
    }
}