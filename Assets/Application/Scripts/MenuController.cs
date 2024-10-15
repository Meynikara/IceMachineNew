using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button Home_Go_Button;
    [SerializeField] GameObject Home;
    [SerializeField] GameObject AfterHome;
    [SerializeField] GameObject Learn;
    [SerializeField] GameObject Assessment;
    [SerializeField] GameObject Multiplayer;

    [SerializeField] GameObject Learn_Installation;
    [SerializeField] GameObject Repair_Installation;
    [SerializeField] Button Learn_Go_Button;

    [SerializeField] GameObject Explore_Learn;

    [SerializeField] GameObject Assessment_Installation;
    [SerializeField] GameObject Assessment_Repair;
    [SerializeField] GameObject Multiplayer_Installation;
    [SerializeField] GameObject Multiplayer_Repair;
    [SerializeField] Button Assessment_Go_Button;
    [SerializeField] Button Multiplayer_Go_Button;

    [SerializeField] GameObject Installation_Learn;   
    [SerializeField] Button Techie_Learn_Installation_Go_Button; 
    [SerializeField] GameObject Repair_Learn;
    [SerializeField] Button Techie_Learn_Repair_Go_Button;

    [SerializeField] Button Techie_Assessment_Installation_Go_Buttton;
    [SerializeField] Button Techie_Assessment_Repair_Go_Buttton;
    [SerializeField] Button Techie_Multiplayer_Installation_Go_Button;
    [SerializeField] Button Techie_Multiplayer_Repair_Go_Button;

    [SerializeField] GameObject menulist;
    string homebuttonval;
    string learnmodule;
    string assessmentmodule;
    string multiplayermodule;
    string techielearninstallation;
    string techielearnrepair;
    string techieassessmentinstallation;
    string techieassessmentrepair;
    string techiemultiplayerinstallation;
    string techiemultiplayerrepair;
    int menuval;
    public void HomeButtons(string val)
    {
        homebuttonval = val;
        Home_Go_Button.gameObject.SetActive(true);

    }
    public void GoinHome()
    {
        if (homebuttonval == "Learn")
        {
            Learn.SetActive(true);
        }
        if (homebuttonval == "Assessment")
        {
            Assessment.SetActive(true);
        }
        if (homebuttonval == "Multiplayer")
        {
            Multiplayer.SetActive(true);

        }
        Home.SetActive(false);
        AfterHome.SetActive(true);
        Home_Go_Button.gameObject.SetActive(false);
    }
    public void Goback(string method)
    {
        if (homebuttonval == "Learn")
        {
            Learn.SetActive(false);
            Home.SetActive(true);
        }
        if (homebuttonval == "Assessment")
        {
            Assessment.SetActive(false);
            Home.SetActive(true);
        }
        if (homebuttonval == "Multiplayer")
        {
            Multiplayer.SetActive(false);
            Home.SetActive(true);

        }


      
       
    }
    public void MenuCtrl()
    {
        menuval++;
        if (menuval %2 == 0)
        {
            menulist.SetActive(false);
        }
        else
        {
            menulist.SetActive(true);
        }
    }
    public void GoHome()
    {
        AfterHome.SetActive(false);
        Learn.SetActive(false);
        Assessment.SetActive(false);
        Multiplayer.SetActive(false);
        Home.SetActive(true);
        Installation_Learn.SetActive(false);
        Repair_Learn.SetActive(false);
        Assessment_Installation.SetActive(false);
        Assessment_Repair.SetActive(false);
        Multiplayer_Installation.SetActive(false);
        Multiplayer_Repair.SetActive(false);
    }
    public void LearnModule(string val)
    {
        learnmodule = val;
        Learn_Go_Button.gameObject.SetActive(true);
    }
    public void GoLearn()
    {
        if(learnmodule == "Explore")
        {
            Explore_Learn.SetActive(true);
            Learn.SetActive(false);
        }
        if(learnmodule == "Installation")
        {
            Installation_Learn.SetActive(true);
            Learn.SetActive(false);
        }
        if(learnmodule == "Repair")
        {
            Repair_Learn.SetActive(true);
            Learn.SetActive(false);    
        }
       
    }
    public void AssessmentModule(string val)
    {
        assessmentmodule = val;
        Assessment_Go_Button.gameObject.SetActive(true);
    }
    public void GoAssessment()
    {
        if(assessmentmodule == "Installation")
        {
            Assessment_Installation.SetActive(true);
            Assessment.SetActive (false);
            
        }
        if(assessmentmodule == "Repair")
        {
            Assessment_Repair.SetActive(true);
            Assessment.SetActive (false);
        }
    }
    public void MultiplayerModule(string val)
    {
        multiplayermodule = val;    
        Multiplayer_Go_Button.gameObject.SetActive(true);
    }
    public void GoMultiplayer()
    {
        if(multiplayermodule == "Installation")
        {
            Multiplayer_Installation.SetActive(true);
            Multiplayer.SetActive (false);
        }
        if(multiplayermodule == "Repair")
        {
            Multiplayer_Repair.SetActive (true);
            Multiplayer.SetActive (false);
        }
    }
    public void LearnBack()
    {
        Learn.SetActive(true);
        Explore_Learn.SetActive(false);
        Installation_Learn.SetActive(false);
        Repair_Learn.SetActive(false);
        Techie_Learn_Installation_Go_Button.gameObject.SetActive(false);
        Techie_Learn_Repair_Go_Button.gameObject.SetActive(false);
        Learn_Go_Button.gameObject.SetActive(false);
    }
    public void AssessmentBack()
    {
        Assessment.SetActive(true);
        Assessment_Installation.SetActive(false);
        Assessment_Repair.SetActive(false);
        Techie_Assessment_Installation_Go_Buttton.gameObject.SetActive(false);
        Techie_Assessment_Repair_Go_Buttton.gameObject.SetActive(false);
        Assessment_Go_Button.gameObject.SetActive(false);
    }
    public void MultiplayerBack()
    {
        Multiplayer.SetActive(true);
        Multiplayer_Installation.SetActive(false);
        Multiplayer_Repair.SetActive(false);
        Techie_Multiplayer_Installation_Go_Button.gameObject.SetActive(false);
        Techie_Assessment_Repair_Go_Buttton.gameObject.SetActive(false);
        Multiplayer_Go_Button.gameObject.SetActive(false);
    }
    public void TechniciansLearn_Installation(string techiename)
    {
        techielearninstallation = techiename;
        Techie_Learn_Installation_Go_Button.gameObject.SetActive(true);
    }
    public void TechniciansLearn_Repair(string techiename)
    {
        techielearnrepair = techiename;
        Techie_Learn_Repair_Go_Button.gameObject.SetActive(true);
    }
    public void TechniciansAssessment_Installation(string techiename)
    {
        techieassessmentinstallation = techiename;
        Techie_Assessment_Installation_Go_Buttton.gameObject.SetActive(true);
    } 
    public void TechniciansAssessment_Repair(string techiename)
    {
        techieassessmentrepair = techiename;
        Techie_Assessment_Repair_Go_Buttton.gameObject.SetActive(true);
    }
    public void TechniciansMultiplayer_Installation(string techiename)
    {
        techiemultiplayerinstallation = techiename;
        Techie_Multiplayer_Installation_Go_Button.gameObject.SetActive(true);
    } 
    public void TechniciansMultiplayer_Repair(string techiename)
    {
        techiemultiplayerrepair = techiename;
        Techie_Multiplayer_Repair_Go_Button.gameObject.SetActive(true);
    }
}