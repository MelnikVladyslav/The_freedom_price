using Assets.Scripts.Navigatiion.Funcs;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets.Scripts.Navigatiion
{
    public class TechnologyMechanic : MonoBehaviour
    {
        public EnterNation enterNation;
        public StartScriptsInitilazer start;
        public SkipTurn skipTurn;
        public Text Techs;
        public InputField inputField;
        public Text NameTech;
        public Text DetInfo;
        public Text KilkHod;
        string name = "";
        int idTech = -1;

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < start.TechnologyList.Count; i++)
            {
                name = start.TechnologyList[i].Name;
                for (int j = 0; j < enterNation.countryPlayer.techs.Count; j++)
                {
                    if (name == enterNation.countryPlayer.techs[j].Name)
                    {
                        idTech = j;
                    }
                    if (idTech != -1)
                    {
                        i++;
                        idTech = -1;
                        break;
                    }
                }

            }

                Techs.text += "Civil" + "\n";
            for (int i = 0; i < start.TechnologyList.Count; i++)
            {
                if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Civil)
                {
                    Techs.text += start.TechnologyList[i].Name + "\n";
                }
            }

                Techs.text += "Viyskova promuslovisty" + "\n";
            for (int i = 0; i < start.TechnologyList.Count; i++)
            {
                if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Viyskov)
                {
                    Techs.text += start.TechnologyList[i].Name + "\n";
                }
            }

                Techs.text += "Army" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.Army) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Technika" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.Technika) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Air" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.Air) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Flot" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++)
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.Flot) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Country" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.Country) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Land doctrine" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.LandDoctrine) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

                Techs.text += "Air doctrine" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) 
			{
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.AirDoctrine) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}

			Techs.text += "Naval doctrine" + "\n";
			for (int i = 0; i < start.TechnologyList.Count; i++) {
				if (start.TechnologyList[i].isOpen == false && start.TechnologyList [i].typeTech == TypeTech.FlotDoctrine) {
					Techs.text += start.TechnologyList [i].Name + "\n";
				}
			}
            
        }

        public void StartTechMech()
        {
            NameTech.text = "";
            DetInfo.text = "";
            KilkHod.text = "";
        }

        public void FindTech()
        {
            string name = inputField.text;

            for (int i = 0; i < start.TechnologyList.Count; i++)
            {
                if (name == start.TechnologyList[i].Name)
                {
                    NameTech.text = name;
                    KilkHod.text = start.TechnologyList[i].Time.ToString() + " turns";
                    if(start.TechnologyList[i].PlusArm != 0)
                    {
                        DetInfo.text = "Update army and army promuslovisty";
                    }
                    else if (start.TechnologyList[i].PlusCiv != 0)
                    {

                        DetInfo.text = "Update civil promuslovisty";
                    }
                    else if (start.TechnologyList[i].PlusCount != 0)
                    {

                        DetInfo.text = "Update country parametres";
                    }
                    else if (start.TechnologyList[i].PlusCiv == 0 && start.TechnologyList[i].PlusArm == 0 && start.TechnologyList[i].PlusCount == 0)
                    {

                        DetInfo.text = "Open to new technology";
                    }
                    for (int j = 0; j < start.TechnologyList[i].polks.Count; j++)
                    {
                        DetInfo.text += "\n" + "Open " + start.TechnologyList[i].polks[j].Name;
                    }
                    for (int j = 0; j < start.TechnologyList[i].builds.Count; j++)
                    {
                        DetInfo.text += "\n" + "Open " + start.TechnologyList[i].builds[j].Name;
                    }
                    if (start.TechnologyList[i].isOpen == true)
                    {
                        DetInfo.text += "\n" + "Is technology open";
                    }
                    
                }
            }
        }

        public void EnterTech()
        {

            for (int i = 0; i < start.TechnologyList.Count; i++)
            {
                if (start.TechnologyList[i].Name == NameTech.text)
                {
                    skipTurn.idTech = i;
                }
            }

            skipTurn.currentTech.Name = start.TechnologyList[skipTurn.idTech].Name;
            skipTurn.currentTech.typeTech = start.TechnologyList[skipTurn.idTech].typeTech;
            skipTurn.currentTech.PlusArm = start.TechnologyList[skipTurn.idTech].PlusArm;
            skipTurn.currentTech.PlusCiv = start.TechnologyList[skipTurn.idTech].PlusCiv;
            skipTurn.currentTech.PlusCount = start.TechnologyList[skipTurn.idTech].PlusCount;
            for (int i = 0; i < start.TechnologyList[skipTurn.idTech].polks.Count; i++)
            {
                skipTurn.currentTech.polks.Add(start.TechnologyList[skipTurn.idTech].polks[i]);
            }
            for (int i = 0; i < start.TechnologyList[skipTurn.idTech].builds.Count; i++)
            {
                skipTurn.currentTech.builds.Add(start.TechnologyList[skipTurn.idTech].builds[i]);
            }

            DetInfo.text += "\nOpenning..."; 
        }

        // Update is called once per frame
        void Update()
        {
            if (start.TechnologyList[skipTurn.idTech].isOpen == true)
            {
                Techs.text = "";

                Techs.text += "Civil" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Civil)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Viyskova promuslovisty" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Viyskov)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Army" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Army)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Technika" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Technika)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Air" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Air)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Flot" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Flot)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Country" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.Country)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Land doctrine" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.LandDoctrine)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Air doctrine" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.AirDoctrine)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

                Techs.text += "Naval doctrine" + "\n";
                for (int i = 0; i < start.TechnologyList.Count; i++)
                {
                    if (start.TechnologyList[i].isOpen == false && start.TechnologyList[i].typeTech == TypeTech.FlotDoctrine)
                    {
                        Techs.text += start.TechnologyList[i].Name + "\n";
                    }
                }

            }
        }
    }
}