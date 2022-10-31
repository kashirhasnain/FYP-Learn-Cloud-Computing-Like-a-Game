using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Crosstales.RTVoice.Tool;
public class kubernetes_raycast : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera usecam2;
    public GameObject[] Server_;
    public Material red;
    public Material green;
    public int trig;
    public int amount_size,amount_vister,fakesize,fakevister;
    public int checksize, checkvister;
    public GameObject quizpanel,winpanel,gameover;

    public int score,trig1;
    public bool uncheck;

    public float timeawait;

    public int trig_speak;
    public GameObject speakobj;

    public bool iscolltrig;

    public Text scoreshow1;
    void Start()
    {
       
        fakesize = kuberbetes.kuberbetes_.filesize;
        fakesize += 50;
        fakevister = kuberbetes.kuberbetes_.visiters;
        fakevister += 10;

        checksize = (int)kuberbetes.kuberbetes_.filesize / 50;
        checkvister = (int)kuberbetes.kuberbetes_.visiters / 10;

        if (kuberbetes.kuberbetes_.islearn == false)
        {
            quizpanel.SetActive(true);

            foreach (GameObject fakeobj in Server_)
            {
                fakeobj.GetComponent<Renderer>().material = red;
                fakeobj.GetComponent<Renderer>().material.color = Color.red;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider.name == "buyyes")
            {
                kuberbetes.kuberbetes_.isserverbuy = true;
                kuberbetes.kuberbetes_.On_server();
                kuberbetes.kuberbetes_.limitpanel.SetActive(false);
                kuberbetes.kuberbetes_.server.SetActive(true);
            }
            if (hit.collider.name == "buyno")
            {
                kuberbetes.kuberbetes_.isserverbuy = false;
                //kuberbetes.kuberbetes_.On_server();
                kuberbetes.kuberbetes_.limitpanel.SetActive(false);
                kuberbetes.kuberbetes_.server.SetActive(true);
            }
            if (hit.collider.gameObject.name == "home")
            {
                Application.LoadLevel(0);
                speakobj.GetComponent<SpeechText>().Silence();
            }
            if (hit.collider.gameObject.name == "kbspeak")
            {
                if (trig_speak == 0)
                {
                    speakobj.GetComponent<SpeechText>().Speak();
                    trig_speak = 1;

                }
            }
            if (hit.collider.gameObject.name == "kbstop")
            {
                if (trig_speak == 1)
                {
                    speakobj.GetComponent<SpeechText>().Silence();
                    trig_speak = 0;
                }
            }
            if (kuberbetes.kuberbetes_.islearn == false)
            {
                if (iscolltrig == true)
                {
                    if (hit.collider.gameObject.GetComponent<Renderer>().material.color == Color.red)
                    {
                        hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                        amount_size += 50;
                        amount_vister += 10;
                        //hit.collider.gameObject.GetComponent<boxchecker>().ischecked = true;
                    }
                    else if (hit.collider.gameObject.GetComponent<Renderer>().material.color == Color.green)
                    {
                        hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                        amount_size -= 50;
                        amount_vister -= 10;
                        //hit.collider.gameObject.GetComponent<boxchecker>().ischecked = false;
                    }
                    iscolltrig = false;
                }

                if (hit.collider.gameObject.name == "restart")
                {
                    Application.LoadLevel(0);
                }
                
                if (hit.collider.gameObject.name == "submit")
                {

                    if (amount_size >= kuberbetes.kuberbetes_.filesize)
                    {
                        if (amount_size < fakesize)
                        {
                            if (trig1 == 0)
                            {


                                if (checksize >= checkvister)
                                {
                                    print("jobdone");
                                    kuberbetes.kuberbetes_.server.SetActive(false);
                                    winpanel.SetActive(true);
                                    score = 10;
                                    PlayerPrefs.SetInt("kub_scorekey", score);
                                }
                                else
                                {
                                    score = -10;
                                    kuberbetes.kuberbetes_.server.SetActive(false);
                                    gameover.SetActive(true);
                                    PlayerPrefs.SetInt("kub_scorekey", score);
                                }
                                trig1 = 1;
                            }

                        }
                        else
                        {
                            if (trig1 == 0)
                            {




                                score =- 10;
                                kuberbetes.kuberbetes_.server.SetActive(false);
                                gameover.SetActive(true);

                            }
                        }
                    }
                    else
                    {
                        if (trig1 == 0)
                        {




                            score = -10;
                            kuberbetes.kuberbetes_.server.SetActive(false);
                            gameover.SetActive(true);
                            trig1 = 1;
                        }
                    }
                    if (amount_vister >= kuberbetes.kuberbetes_.visiters)
                    {
                        if (trig1 == 0)
                        {
                            if (amount_vister < fakevister)
                            {
                                if (checksize <= checkvister)
                                {
                                    print("jobdone");
                                    kuberbetes.kuberbetes_.server.SetActive(false);
                                    winpanel.SetActive(true);
                                    score = 10;
                                }
                                else
                                {
                                    score = -10;
                                    kuberbetes.kuberbetes_.server.SetActive(false);
                                    gameover.SetActive(true);
                                }
                            }
                            else
                            {
                                score = -10;
                                kuberbetes.kuberbetes_.server.SetActive(false);
                                gameover.SetActive(true);
                            }
                            trig1 = 1;
                        }
                    }
                    else
                    {
                        if (trig1 == 0)
                        {




                            score -= 10;
                            kuberbetes.kuberbetes_.server.SetActive(false);
                            gameover.SetActive(true);
                            trig1 = 1;
                        }
                    }

                }

            }
            Debug.Log("Did Hit");
        }
        else
        {
            
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
            iscolltrig = true;
        }
        scoreshow1.text = "Score : "+score.ToString();
        //Ray ray = usecam2.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit, 10000))
        //{
        //    Debug.DrawLine(ray.origin, hit.point);

        //}

    }
}
