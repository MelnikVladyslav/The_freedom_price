using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion.Funcs
{
    public class Builds : MonoBehaviour
    {
        public NavigationDown navigationDown;
        public EnterNation enterNation;
        public SkipTurn skipTurn;
        public InputField nameBuild;
        public Text listBuilds;
        public Text infoBuild;
        int kilkBuild = 0;
        int idBuild = 0;

        public void Start()
        {
            for (int i = 0; i < enterNation.countryPlayer.openBuilds.Count; i++)
            {
                listBuilds.text += enterNation.countryPlayer.openBuilds[i].Name + "     Price: " + enterNation.countryPlayer.openBuilds[i].Price + "\n";
            }
        }

        public void FindBuild()
        {
            for (int i = 0; i < enterNation.countryPlayer.openBuilds.Count; i++)
            {

                if (enterNation.countryPlayer.openBuilds[i].Name == nameBuild.text && enterNation.countryPlayer.openBuilds[i].Type == TypeBuild.Lehka)
                {
                    idBuild = i;
                    infoBuild.text = "Upgrade civilian promuslivisty on " + enterNation.countryPlayer.openBuilds[i].Dohid;
                }
                if (enterNation.countryPlayer.openBuilds[i].Name == nameBuild.text && enterNation.countryPlayer.openBuilds[i].Type == TypeBuild.Big)
                {
                    idBuild = i;
                    infoBuild.text = "Upgrade army promuslivisty on " + enterNation.countryPlayer.openBuilds[i].ZnArmy;
                }
                if (enterNation.countryPlayer.openBuilds[i].Name == nameBuild.text && enterNation.countryPlayer.openBuilds[i].Type == TypeBuild.Defend)
                {
                    idBuild = i;
                    infoBuild.text = "Upgrade defend region on " + enterNation.countryPlayer.openBuilds[i].Damage;
                }
            }
        }

        public void Build()
        {
            if (enterNation.countryPlayer.Money < enterNation.countryPlayer.openBuilds[idBuild].Price || enterNation.countryPlayer.BuildResourse < enterNation.countryPlayer.openBuilds[idBuild].Price / 2)
            {

            }
            else
            {
                enterNation.countryPlayer.Money -= enterNation.countryPlayer.openBuilds[idBuild].Price;
                enterNation.countryPlayer.BuildResourse -= enterNation.countryPlayer.openBuilds[idBuild].Price / 2;

                skipTurn.currentBuild.Add(enterNation.countryPlayer.openBuilds[idBuild]);
                skipTurn.idsRegions.Add(navigationDown.idRegion);
            }

        }
    }
}