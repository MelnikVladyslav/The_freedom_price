using Assets.Class.Army;
using Assets.Scripts.Navigatiion.Funcs;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GeneratorbattleMap.ArmyBattle
{
    public class Battle : MonoBehaviour
    {
        public EnterTheTypeBatle enter;
        public RawImage currentImg;
        public bool isNull = true;

        //Polk
        public Text listPolks;
        public InputField enterName;
        public GameObject EnterPolks;
        public List<PolkBattle> youPolks = new List<PolkBattle>();
        public List<PolkBattle> enemyPolks = new List<PolkBattle>();
        public List<PolkBattle> youPolksInMap = new List<PolkBattle>();
        public List<PolkBattle> enemyPolksInMap = new List<PolkBattle>();
        public List<Texture> polksBattle = new List<Texture>();

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < enter.skip.listMovedDiv[enter.idMovedDiv].movedDiv.polks.Count; i++)
            {
                youPolks.Add
                (
                    new PolkBattle
                    { 
                        polk = enter.skip.listMovedDiv[enter.idMovedDiv].movedDiv.polks[i],
                        typePolk = Class.Army.TypePolk.My
                    }
                );
            }

            for (int i = 0; i < enter.start.RegionList[enter.skip.listMovedDiv[enter.idMovedDiv].idEndReg].divisions.Count; i++)
            {
                for (int j = 0; j < enter.start.RegionList[enter.skip.listMovedDiv[enter.idMovedDiv].idEndReg].divisions[i].polks.Count; j++)
                {
                    enemyPolks.Add
                    (
                        new PolkBattle
                        {
                            polk = enter.start.RegionList[enter.skip.listMovedDiv[enter.idMovedDiv].idEndReg].divisions[i].polks[j],
                            typePolk = Class.Army.TypePolk.My
                        }
                    );
                }
            }
        }

        public void EnterPolk(RawImage cellImage)
        {
            if (isNull != false)
            {
                currentImg = cellImage;

                listPolks.text = "";
                for (int i = 0; i < youPolks.Count; i++)
                {
                    listPolks.text += youPolks[i].polk.Name + "\n";
                }

                EnterPolks.gameObject.SetActive(true);
            }
        }

        public void Enter()
        {
            if (enterName.text != " ")
            {
                for (int i = 0; i < youPolks.Count; i++)
                {
                    if (youPolks[i].polk.Name == enterName.text)
                    {
                        if (enterName.text == "Garrizon")
                        {
                            currentImg.texture = polksBattle[0];
                        }
                        if (enterName.text == "Pihota")
                        {
                            currentImg.texture = polksBattle[1];
                        }
                        if (enterName.text == "Artillery")
                        {
                            currentImg.texture = polksBattle[2];
                        }
                        if (enterName.text == "Btr")
                        {
                            currentImg.texture = polksBattle[3];
                        }
                        if (enterName.text == "Motorized")
                        {
                            currentImg.texture = polksBattle[4];
                        }
                        if (enterName.text == "Mechanized")
                        {
                            currentImg.texture = polksBattle[5];
                        }
                        if (enterName.text == "Light Tank")
                        {
                            currentImg.texture = polksBattle[6];
                        }
                        if (enterName.text == "Medium Tank")
                        {
                            currentImg.texture = polksBattle[7];
                        }
                        if (enterName.text == "Heavy Tank")
                        {
                            currentImg.texture = polksBattle[8];
                        }

                        youPolksInMap.Add(youPolks[i]);
                        youPolks.Remove(youPolks[i]);
                    }
                }
            }

            EnterPolks.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}