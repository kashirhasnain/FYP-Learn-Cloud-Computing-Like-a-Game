using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Crosstales.RTVoice.Tool;
public class raycast_hit : MonoBehaviour
{
    public Camera usecam;
    public GameObject usecam1;
    public GameObject Room;
    public static bool isquiz2;
    public Text Isq2q;
    public GameObject[] fakeobjects;
    public bool ispro, ishard, isram,isother;
    public float timeawait;
    public Transform camepos2;
    public Transform camepos3;
    public Transform fakepos;

    public int trig1_config, trig2_config, trig3_config,speak_trig;

    public static raycast_hit os_fake;

    public GameObject[] speaks;

    public GameObject high1, high2, high3;

    public bool uncheck_trig;
    public static int fakepro, fakehard, fakeram;

    public GameObject Fake_camera;
    public void Start()
    {
        os_fake = this;
        fakepos.position = usecam.GetComponent<Transform>().position;
        Room.SetActive(true);
        high1.GetComponent<Renderer>().material.color = Color.red;
        high2.GetComponent<Renderer>().material.color = Color.red;
        high3.GetComponent<Renderer>().material.color = Color.red;
       // SpeechText.speechText_.Speak();
    }
    void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (isquiz2 == true)
        {
            foreach (GameObject fg in fakeobjects)
            {
                fg.SetActive(true);
            }
        }
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider.gameObject.tag == "Pro")
            {
                
                if (isquiz2 == false)
                {
                    if (high1.GetComponent<Renderer>().material.color == Color.red)
                    {
                        print("Pro hit");
                        GameController.controller_.module = 0;
                        GameController.controller_.defval = 0;
                        GameController.controller_.Start();
                        usecam1.SetActive(false);
                        Fake_camera.SetActive(true);
                        high1.GetComponent<Renderer>().material.color = Color.green;
                        high2.GetComponent<Renderer>().material.color = Color.red;
                        high3.GetComponent<Renderer>().material.color = Color.red;
                    }
                   
                    
                    if (Input.GetMouseButtonDown(0))
                    {
                        Room.SetActive(false);
                        GameController.controller_.module = 0;
                        GameController.controller_.defval = 0;
                        GameController.controller_.Start();
                        usecam.GetComponent<Transform>().position = camepos2.position;
                    }
                }
                else
                {
                    high1.GetComponent<Renderer>().material.color = Color.green;
                    ispro = true;
                    

                }
               

            }
            if (hit.collider.gameObject.tag == "others")
            {
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                isother = true;
            }
            if (hit.collider.gameObject.tag == "Hard")
            {
                
                if (isquiz2 == false)
                {
                    if (high2.GetComponent<Renderer>().material.color == Color.red)
                    {

                    
                    print("hard hit");
                    
                    GameController.controller_.module = 1;
                    GameController.controller_.defval = 0;
                    GameController.controller_.Start();
                    usecam1.SetActive(false);
                    Fake_camera.SetActive(true);
                    high1.GetComponent<Renderer>().material.color = Color.red;
                    high2.GetComponent<Renderer>().material.color = Color.green;
                    high3.GetComponent<Renderer>().material.color = Color.red;

                    }
                    if (Input.GetMouseButtonDown(0))
                    {
                        //Room.SetActive(false);
                        GameController.controller_.module = 1;
                        GameController.controller_.defval = 0;
                        GameController.controller_.Start();
                        usecam.GetComponent<Transform>().position = camepos2.position;
                    }
                    if (timeawait > 2f)
                    {
                        //Room.SetActive(false);
                      
                    }
                    else
                    {
                        timeawait += 1 * Time.deltaTime;
                    }
                }
                else
                {
                    high2.GetComponent<Renderer>().material.color = Color.green;
                    ishard = true;
                }

            }
            if (hit.collider.gameObject.tag == "Ram")
            {
               
                if (isquiz2 == false)
                {
                    if (high3.GetComponent<Renderer>().material.color == Color.red)
                    {
                        print("Ram hit");
                        //high3.GetComponent<Renderer>().material.color = Color.green;

                        //Room.SetActive(false);
                        GameController.controller_.defval = 2;
                        GameController.controller_.Start();
                        GameController.controller_.OnRam();
                        usecam1.SetActive(false);
                        Fake_camera.SetActive(true);
                        high1.GetComponent<Renderer>().material.color = Color.red;
                        high2.GetComponent<Renderer>().material.color = Color.red;
                        high3.GetComponent<Renderer>().material.color = Color.green;
                    }
                    if (Input.GetMouseButtonDown(0))
                    {
                        Room.SetActive(false);
                        GameController.controller_.defval = 2;
                        GameController.controller_.Start();
                        GameController.controller_.OnRam();
                        usecam.GetComponent<Transform>().position = camepos2.position;
                    }
                }
                else
                {
                    high3.GetComponent<Renderer>().material.color = Color.green;
                    isram = true;
                }

            }
            if (hit.collider.gameObject.name == "home")
            {
                Application.LoadLevel(0);
                speaks[0].GetComponent<SpeechText>().Silence();
                speaks[1].GetComponent<SpeechText>().Silence();
                speaks[2].GetComponent<SpeechText>().Silence();

            }
            if (hit.collider.gameObject.name == "restart")
            {
                Application.LoadLevel(1);
            }
            if (hit.collider.gameObject.name == "pro_speak")
            {
                if (speak_trig == 0)
                {
                    speaks[0].GetComponent<SpeechText>().Speak();
                    speak_trig = 1;
                }
                
            }
            if (hit.collider.gameObject.name == "pro_stop")
            {
                if (speak_trig == 1)
                {
                    speaks[0].GetComponent<SpeechText>().Silence();
                    speak_trig = 0;
                }
                
            }

            if (hit.collider.gameObject.name == "ram_speak")
            {
                if (speak_trig == 0)
                {
                    speaks[2].GetComponent<SpeechText>().Speak();
                    speak_trig = 1;
                }

            }
            if (hit.collider.gameObject.name == "ram_stop")
            {
                if (speak_trig == 1)
                {
                    speaks[2].GetComponent<SpeechText>().Silence();
                    speak_trig = 0;
                }

            }

            if (hit.collider.gameObject.name == "hard_speak")
            {
                if (speak_trig == 0)
                {
                    speaks[1].GetComponent<SpeechText>().Speak();
                    speak_trig = 1;
                }

            }
            if (hit.collider.gameObject.name == "hard_stop")
            {
                if (speak_trig == 1)
                {
                    speaks[1].GetComponent<SpeechText>().Silence();
                    speak_trig = 0;
                }

            }

            if (hit.collider.gameObject.tag == "Done")
            {
               // usecam.GetComponent<Transform>().position = new Vector3(487, -78, 1363);
               
                if (isquiz2 == false)
                {
                    print("Done hit");
                    Room.SetActive(true);
                  GameController.controller_.OnDone();
                    usecam1.SetActive(false);
                    Fake_camera.SetActive(true);


                    if (Input.GetMouseButtonDown(0))
                    {
                        Room.SetActive(false);
                        GameController.controller_.OnDone();
                        //Room.SetActive()
                        //module = 3;
                        usecam.GetComponent<Transform>().position = new Vector3(487, -78, 1363);
                        // GameController.controller_.defval = 2;

                        // GameController.controller_.Start();
                    }
                }
                else
                {
                    if (ispro == true && ishard == true && isram==true&&isother!=true)
                    {
                        print("Correct");
                        GameController.islearning = false;

                        GameController.controller_.Start();
                        GameController.controller_.osscore += 10;
                        PlayerPrefs.SetInt("Os_scorekey", GameController.controller_.osscore);
                        print(GameController.controller_.osscore);
                        PlayerPrefs.SetInt("Os_quiz1", 1);
                    }
                    else
                    {
                        GameController.islearning = false;

                        GameController.controller_.Start();
                        //GameController.controller_.osscore -= 10;
                        PlayerPrefs.SetInt("Os_scorekey", GameController.controller_.osscore);
                        print(GameController.controller_.osscore);
                    }
                }

            }
            if (hit.collider.gameObject.name == "op_done")
            {
                //GameController.controller_.OnPCConfig();
                //usecam1.GetComponent<Transform>().localRotation = Quaternion.Euler(0, -90, 0);
                Application.LoadLevel(1);
                usecam1.SetActive(true);
                Fake_camera.SetActive(false);
              
                speaks[0].GetComponent<SpeechText>().Silence();
                speaks[1].GetComponent<SpeechText>().Silence();
                speaks[2].GetComponent<SpeechText>().Silence();
                speak_trig = 0;
            }
            if (hit.collider.gameObject.tag == "onvmware")
            {
                GameController.controller_.OnVMware();
            }
            if (hit.collider.gameObject.tag == "onbuntu")
            {
                GameController.controller_.OnOS_panel();
                GameController.controller_.OnUbuntu();
            }
            if (hit.collider.gameObject.tag == "onwin")
            {
                GameController.controller_.OnOS_panel();
                GameController.controller_.OnWin();
            }
            if (hit.collider.gameObject.tag == "onlinux")
            {
                GameController.controller_.OnOS_panel();
                GameController.controller_.OnLinux();
            }
            if (hit.collider.gameObject.tag == "pro2")
            {
                fakepro = 2;
                if (trig1_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                   // fakepro = 2;
                    trig1_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "pro4")
            {
                fakepro = 4;
                if (trig2_config == 0)
                {
                    
                    trig2_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "pro6")
            {
                fakepro = 8;
                if (trig3_config == 0)
                {
                    
                    trig3_config = 1;
                }

            }

            /*******
             * Hard
             * *****/

            if (hit.collider.gameObject.tag == "hard1")
            {
                fakehard = 2;
                if (trig2_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                    
                    trig2_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "hard2")
            {
                fakehard = 4;
                if (trig2_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                   // fakehard = 4;
                    trig2_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "hard3")
            {
                fakehard = 8;
                if (trig2_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                   // fakehard = 8;
                    trig2_config = 1;
                }

            }

            /*******
           * RAM
           * *****/
            if (hit.collider.gameObject.tag == "ram1")
            {
                fakeram = 2;
                if (trig3_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                   
                    trig3_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "ram2")
            {
                fakeram = 4;
                if (trig3_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                    
                    trig3_config = 1;
                }

            }
            if (hit.collider.gameObject.tag == "ram3")
            {
                fakeram = 8;
                if (trig3_config == 0)
                {
                    //GameController.controller_.onconfigval1();
                    
                    trig3_config = 1;
                }

            }


            if (hit.collider.gameObject.tag == "submit")
            {
                GameController.controller_.OnConfigSubmit();
            }

            if (hit.collider.gameObject.tag == "osconfigback")
            {
                GameController.controller_.on_OSconfig_back();
                trig1_config = 0;
                trig2_config = 0;
                trig3_config = 0;
                fakeram = 0;
                fakepro = 0;
                fakehard = 0;
            }
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
            uncheck_trig = false;
        }
        //Ray ray = usecam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (isquiz2 == true)
        //{
        //    Isq2q.text = "Select components to assemble the PC";
        //    foreach (GameObject fg in fakeobjects)
        //    {
        //        fg.SetActive(true);
        //    }
        //}
        //if (Physics.Raycast(ray, out hit, 2000))
        //{
        //    Debug.DrawLine(ray.origin, hit.point);
        //    if (hit.collider.gameObject.tag == "Pro")
        //    {
        //        if (isquiz2 == false)
        //        {
        //            print("Pro hit");
        //            if (timeawait > 2f)
        //            {
        //                Room.SetActive(false);
        //                GameController.controller_.module = 0;
        //                GameController.controller_.defval = 0;
        //                GameController.controller_.Start();
        //            }
        //            else
        //            {
        //                timeawait += 1 * Time.deltaTime;
        //            }
        //            if (Input.GetMouseButtonDown(0))
        //            {
        //                Room.SetActive(false);
        //                GameController.controller_.module = 0;
        //                GameController.controller_.defval = 0;
        //                GameController.controller_.Start();
        //                usecam.GetComponent<Transform>().position = camepos2.position;
        //            }
        //        }
        //        else
        //        {
        //            ispro = true;
        //        }

        //    }
        //    if (hit.collider.gameObject.tag == "Hard")
        //    {
        //        if (isquiz2 == false)
        //        {
        //            print("hard hit");
        //            if (Input.GetMouseButtonDown(0))
        //            {
        //                //Room.SetActive(false);
        //                GameController.controller_.module = 1;
        //                GameController.controller_.defval = 0;
        //                GameController.controller_.Start();
        //                usecam.GetComponent<Transform>().position = camepos2.position;
        //            }
        //            if (timeawait > 2f)
        //            {
        //                //Room.SetActive(false);
        //                GameController.controller_.module = 1;
        //                GameController.controller_.defval = 0;
        //                GameController.controller_.Start();
        //                usecam.GetComponent<Transform>().position = camepos2.position;
        //            }
        //            else
        //            {
        //                timeawait += 1 * Time.deltaTime;
        //            }
        //        }
        //        else
        //        {
        //            ishard = true;
        //        }
                
        //    }
        //    if (hit.collider.gameObject.tag == "Ram")
        //    {
        //        if (isquiz2 == false)
        //        {
        //            print("Ram hit");
        //            if (Input.GetMouseButtonDown(0))
        //            {
        //                Room.SetActive(false);
        //                GameController.controller_.defval = 2;
        //                GameController.controller_.Start();
        //                GameController.controller_.OnRam();
        //                usecam.GetComponent<Transform>().position = camepos2.position;
        //            }
        //        }
        //        else
        //        {
        //            isram = true;
        //        }

        //    }
        //    if (hit.collider.gameObject.tag == "Done")
        //    {
        //        if (isquiz2 == false)
        //        {
        //            print("Done hit");
        //            if (Input.GetMouseButtonDown(0))
        //            {
        //                Room.SetActive(false);
        //                GameController.controller_.OnDone();
        //                usecam.GetComponent<Transform>().position = new Vector3(487, -78, 1363);
        //                // GameController.controller_.defval = 2;

        //                // GameController.controller_.Start();
        //            }
        //        }
        //        else
        //        {
        //            if (ispro == true && ishard == true && isram)
        //            {
        //                print("Correct");
        //                GameController.controller_.islearning = false;

        //                GameController.controller_.Start();
        //                GameController.controller_.osscore += 10;
        //                print(GameController.controller_.osscore);
        //            }
        //            else
        //            {
        //                GameController.controller_.islearning = false;

        //                GameController.controller_.Start();
        //                GameController.controller_.osscore -= 10;
        //                print(GameController.controller_.osscore);
        //            }
        //        }
                
        //    }
        //    if (hit.collider.gameObject.name == "op_done")
        //    {
        //        GameController.controller_.OnPCConfig();
        //        usecam.GetComponent<Transform>().position = fakepos.position;
        //    }
        //    if (hit.collider.gameObject.tag == "onvmware")
        //    {
        //        GameController.controller_.OnVMware();
        //    }
        //    if (hit.collider.gameObject.tag == "onbuntu")
        //    {
        //        GameController.controller_.OnOS_panel();
        //        GameController.controller_.OnUbuntu();
        //    }
        //    if (hit.collider.gameObject.tag == "onwin")
        //    {
        //        GameController.controller_.OnOS_panel();
        //        GameController.controller_.OnWin();
        //    }
        //    if (hit.collider.gameObject.tag == "onlinux")
        //    {
        //        GameController.controller_.OnOS_panel();
        //        GameController.controller_.OnLinux();
        //    }
        //    if (hit.collider.gameObject.tag == "pro2")
        //    {
        //        if (trig1_config == 0)
        //        {
        //            GameController.controller_.onconfigval1();
        //            trig1_config = 1;
        //        }
               
        //    }
        //    if (hit.collider.gameObject.tag == "pro4")
        //    {
        //        if (trig2_config == 0)
        //        {
        //            GameController.controller_.onconfigval2();
        //            trig2_config = 1;
        //        }
               
        //    }
        //    if (hit.collider.gameObject.tag == "pro6")
        //    {
        //        if (trig3_config == 0)
        //        {
        //            GameController.controller_.onconfigval3();
        //            trig3_config = 1;
        //        }

        //    }
        //    if (hit.collider.gameObject.tag == "submit")
        //    {
        //        GameController.controller_.OnConfigSubmit();
        //    }
            
        //    if (hit.collider.gameObject.tag == "osconfigback")
        //    {
        //        GameController.controller_.on_OSconfig_back();
        //        trig1_config = 0;
        //        trig2_config = 0;
        //        trig3_config = 0;
        //    }
        //}
           
    }
}
