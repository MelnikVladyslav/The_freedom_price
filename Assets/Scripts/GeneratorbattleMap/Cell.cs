using Assets.Scripts.GeneratorbattleMap.ArmyBattle;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GeneratorbattleMap
{
    public class Cell : MonoBehaviour
    {
        public Battle battle;
        public Texture standartImg;

        void OnMouseEnter()
        {
            for (int i = 0; i < battle.polksBattle.Count; i++)
            {
                if (battle.polksBattle[i] == transform.GetChild(0).GetComponent<RawImage>().texture)
                {
                    transform.GetChild(0).GetComponent<RawImage>().color = Color.blue;
                    battle.isNull = false;
                }
                if (standartImg == transform.GetChild(0).GetComponent<RawImage>().texture)
                {
                    transform.GetChild(0).GetComponent<RawImage>().color = Color.red; 
                    battle.isNull = true;
                }
            }

        }

        void OnMouseExit()
        {
            transform.GetChild(0).GetComponent<RawImage>().color = Color.white;
        }
    }
}