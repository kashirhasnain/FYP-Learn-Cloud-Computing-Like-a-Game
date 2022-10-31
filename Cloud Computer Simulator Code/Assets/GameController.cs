using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera_main;
    public InputField Config_pro, Config_hard, Config_ram;
    public int module;
    public int defval;
    public GameObject[] Modules;
    public GameObject[] defination;
    public GameObject[] Assemble_obj;
    
    public Button nextbtn, prevbtn;
    public float Timeawait;
    public int temp;
    public int clickcount;

    public int processor, hard, ram;
    public Text Pro_show, hard_show, ram_show;
    //public InputField Pro_input, hard_input, ram_input;
    public Text OS_Name, quizscore;
    public GameObject Room,gameover,gamewin;
    
    /**********
     * Quizer
     * ********/
    public static bool islearning;
    public Text quizq;

    /***********
     * Config comp
     * ***********/
    public int confg_pro;
    public int confg_hard;
    public int confg_ram;
    public static GameController controller_;
    public int configtrig;
    public GameObject[] Os_panel;
    public int osscore;

    public int is_allos;
    public int x_trig;

    public Text paneltext;
    public Text panelover;
    public void Start()
    {
        if (islearning == false)
        {
            quizscore.text = osscore.ToString();
           // quizlabel.text = "Quiz Win";
        }
        else
        {
            quizscore.text = "";
            //quizlabel.text = "Learning comp";
        }
        
        osscore = PlayerPrefs.GetInt("Os_scorekey");
        Room.SetActive(true);
        controller_ = this;
        processor = 16;
        ram = 16;
        hard = 16;
        if (islearning == false)
        {
            Room.SetActive(true);
            camera_main.GetComponent<Transform>().position = new Vector3(487, -78, 1363);
            module = 3;
            paneltext.text = "quiz win";
            panelover.text = "quiz over";
            quizq.text = "Q: You have 3 Os in virtual box config your all Os With given SP of PC.";
            processor = 16;
            ram = 16;
            hard = 16;
        }
        else
        {
            paneltext.text = "Learning completed.";
            panelover.text = "Learning Over.";

        }
        foreach (GameObject fakemoudle in Modules)
        {
            fakemoudle.SetActive(false);
        }
        foreach (GameObject fakedef in defination)
        {
            fakedef.SetActive(false);
        }
        Modules[module].SetActive(true);
        if (module <= 1)
        {
           
            defination[module].SetActive(true);
        }
        
        

        if (module <= 0)
        {
            prevbtn.interactable = false;
            nextbtn.interactable = true;
        }
        else if (module > 0)
        {
            prevbtn.interactable = true;
            nextbtn.interactable = false;
        }
 
    }
    public void OnRam()
    {
        foreach (GameObject fakedef in defination)
        {
            fakedef.SetActive(false);
        }
        defination[defval].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Pro_show.text = processor.ToString()+" Core";
        hard_show.text = hard.ToString() + " TB";
        ram_show.text = ram.ToString() + " GB";
        if (module == 2||module==3)
        {
            if (Timeawait > 2f)
            {
                Assemble_obj[0].SetActive(false);
                Assemble_obj[1].SetActive(true);
                if (temp == 0)
                {

                    Timeawait = 0f;
                    module = 3;
                    Start();
                    Assemble_obj[2].SetActive(true);
                    
                }
                if (temp ==1)
                {

                    //Timeawait = 0f;
                    Assemble_obj[2].SetActive(false);
                    Assemble_obj[3].SetActive(true);
                    print("Desktop");
                    module = 4;
                }
                else
                {
                   
                }
                temp = 1;
            }
            else
            {
                Timeawait += 1 * Time.deltaTime;
               // Assemble_obj[0].SetActive(true);
            }
        }

    }
    public void OnNextBTN()
    {
        if (module <= 0)
        {
            module++;
        }
        Start();
    }
    public void OnPrevBTN()
    {
        if (module > 0)
        {
            module--;
        }
        Start();
    }
    public void OnDone()
    {
        module = 2;
        Start();
    }
    public void OnVMware()
    {
        clickcount++;
        if (clickcount > 1)
        {
            print("Open");
            Assemble_obj[4].SetActive(false);
            Assemble_obj[5].SetActive(true);
            clickcount = 0;
        }

    }
    public void OnOS_panel()
    {
        clickcount++;
        if (clickcount > 1)
        {
            print("Open");
            Assemble_obj[4].SetActive(false);
            Assemble_obj[5].SetActive(false);
            Assemble_obj[6].SetActive(true);
            clickcount = 0;
        }

    }
    public void OnWin()
    {
        OS_Name.text = "Window OS";
    }
    public void OnLinux()
    {
        OS_Name.text = "Linux OS";
    }
    public void OnUbuntu()
    {
        OS_Name.text = "Ubuntu OS";
    }
    public void OnConfigSubmit()
    {
        if (configtrig == 0)
        {
            processor -= raycast_hit.fakepro;
            ram -= raycast_hit.fakeram;
            hard -= raycast_hit.fakehard;
            is_allos++;
            configtrig = 1;
        }
        if (is_allos == 3)
        {
            if (x_trig == 0)
            {

                osscore += 10;
                
                gamewin.SetActive(true);
                Os_panel[0].SetActive(false);
                Os_panel[1].SetActive(false);

                PlayerPrefs.SetInt("Os_scorekey", osscore);
                if (islearning == false)
                {
                    quizscore.text = osscore.ToString();
                }
                else
                {
                    quizscore.text = "";
                }
                x_trig = 1;
            }
            
        }
        //if (processor > 4)
        //{
        //    processor -= confg_pro;
        //   // processor -= int.Parse(Pro_input.text);
        //    //if (int.TryParse(Pro_input.text, out int result))
        //    //{
        //    //    processor = result;
        //    //}
        //}
        //if (ram > 4)
        //{
        //    ram -= confg_ram;
        //    //if (int.TryParse(ram_input.text, out int result))
        //    //{
        //    //    ram = result;
        //    //}
        //    //ram -= int.Parse(ram_input.text);
        //}
        //if (hard > 4)
        //{
        //    hard -= confg_hard;
        //    //if (int.TryParse(hard_input.text, out int result))
        //    //{
        //    //    hard = result;
        //    //}
        //  //  hard -= int.Parse(hard_input.text);
        //}

        

        if (processor <= 0)
        {
            print("pro crashed");
            GameController.controller_.osscore -= 10;
            gameover.SetActive(true);
        }
        if (ram <= 0)
        {
            print("ram crashed");
            GameController.controller_.osscore -= 10;
            gameover.SetActive(true);
        }
        if (hard <= 0)
        {
            print("hard crashed");
            GameController.controller_.osscore -= 10;
            gameover.SetActive(true);
        }
    }

    public void onconfigval1()
    {
        GameController.controller_.processor -= raycast_hit.fakepro;
        GameController.controller_.hard -= raycast_hit.fakehard;
        GameController.controller_.processor -= raycast_hit.fakepro;

    }
    //public void onconfigram()
    //{
    //    confg_pro = 2;
    //    confg_ram = 2;
    //    confg_hard = 2;

    //}
    public void on_OSconfig_back()
    {
        Os_panel[0].SetActive(false);

        Os_panel[1].SetActive(true);
        configtrig = 0;
    }
    public void onconfigval2()
    {
        
        confg_pro = 4;
        confg_ram = 4;
        confg_hard = 4;

    }
    public void onconfigval3()
    {
        confg_pro = 8;
        confg_ram = 8;
        confg_hard = 8;

    }
    public void OnPCConfig()
    {
       // processor = System.Int32.Parse(Config_pro.text);
        if (int.TryParse(Config_pro.text, out int result))
        {
            processor = result;
        }
        if (int.TryParse(Config_hard.text, out int result1))
        {
            hard = result1;
        }
        if (int.TryParse(Config_ram.text, out int result2))
        {
            ram = result2;
        }
        // hard = int.Parse(Config_hard.text);
        //ram -= int.Parse(ram_input.text);
    }
}
