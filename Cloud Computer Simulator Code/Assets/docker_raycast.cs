using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Crosstales.RTVoice.Tool;
public class docker_raycast : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera usecam;
    public static string versionval_;

    public GameObject prompt,promptclose,learn,quiz;
    public static bool isQuiz;
    public float timeawait;
    public Text error_msg_Q;

    public int dockerscore;

    int trig1, trig2;

    public int trig_speak, trig_stop;
    public GameObject speakobj, speakobj1;

    public Text scoreshow;
    void Start()
    {
        if (isQuiz == false)
        {
            learn.SetActive(true);
        }
        else
        {
            quiz.SetActive(true);
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
            if (hit.collider.gameObject.name == "1.1")
            {
                print("1.1");
                versionval_ = "1.1";
                //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                   
                }
            }
            if (hit.collider.gameObject.name == "1.2")
            {
                versionval_ = "1.2";
                //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                   
                    print("1.2");
                }

            }
            if (hit.collider.gameObject.name == "1.3")
            {
                versionval_ = "1.3";
                //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                   
                    print("1.3");
                }
            }
            if (hit.collider.gameObject.tag == "wod")
            {
                Docker.docker_fake.Onwithoutdocker();
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                   
                }
            }
            if (hit.collider.gameObject.tag == "wd")
            {
                Docker.docker_fake.Onwithdocker();
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                    
                }
            }
            if (hit.collider.gameObject.name == "run")
            {
                if (timeawait > 2f)
                {
                    prompt.SetActive(true);
                    print("run");
                }
                else
                {
                    timeawait += 1 * Time.deltaTime;
                }
                if (Input.GetMouseButton(0))
                {
                    prompt.SetActive(true);
                    print("run");
                }
            }
            if (hit.collider.gameObject.name == "yes")
            {
                Docker.docker_fake.Onyes();
                if (Input.GetMouseButton(0))
                {
                   
                }
            }
            if (hit.collider.gameObject.name == "no")
            {
                promptclose.SetActive(false);
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                    
                }
            }
            if (hit.collider.gameObject.name == "yes")
            {
                Docker.docker_fake.Onyes();
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetMouseButton(0))
                {
                  
                }
            }
            if (hit.collider.gameObject.name == "withoutdocker_q")
            {
                if (trig1 == 0)
                {
                    error_msg_Q.text = "Sorry ! this installed version and file version are not same can't execute that.";
                    dockerscore -= 10;
                    scoreshow.text = "Score : " + dockerscore.ToString();
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    trig1 = 1;
                }

                if (Input.GetMouseButton(0))
                {

                }
            }
            if (hit.collider.gameObject.name == "withdocker_q")
            {
                if (trig2 == 0)
                {
                    error_msg_Q.text = "Cpngratulation ! installation processed.";
                    dockerscore += 10;
                    PlayerPrefs.SetInt("docker_scorekey", dockerscore);
                    scoreshow.text = "Score : " + dockerscore.ToString();
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    trig2 = 1;
                }
            }
            if (hit.collider.gameObject.name == "restart")
            {
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                Application.LoadLevel(2);
            }
            if (hit.collider.gameObject.name == "docspeak")
            {

                if (trig_speak == 0)
                {
                    speakobj.GetComponent<SpeechText>().Speak();
                    trig_speak = 1;

                }
            }
            if (hit.collider.gameObject.name == "docstop")
            {
                if (trig_speak == 1)
                {
                    speakobj.GetComponent<SpeechText>().Silence();
                    trig_speak = 0;
                }
            }
            if (hit.collider.gameObject.name == "docspeakq")
            {
                if (trig_speak == 0)
                {
                    speakobj1.GetComponent<SpeechText>().Speak();
                    trig_speak = 1;

                }
            }
            if (hit.collider.gameObject.name == "docstopq")
            {
                if (trig_speak == 1)
                {
                    speakobj1.GetComponent<SpeechText>().Silence();
                    trig_speak = 0;
                }
            }
            if (hit.collider.gameObject.name == "back")
            {
                Application.LoadLevel(0);
                speakobj.GetComponent<SpeechText>().Silence();
            }
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
        scoreshow.text = "Score : " + dockerscore.ToString();
        //Ray ray = usecam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit, 10000))
        //{
        //    Debug.DrawLine(ray.origin, hit.point);

        //}

    }
}
