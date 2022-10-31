using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
public class mainmenu : MonoBehaviour
{
    public int os_score;
    public Text os_show;
    public int docker_score, kub_score;
    public Text docker_score_show;
    public Button btn1, btn2, btn3;
    public GameObject Btn1,Btn2,Btn3;
    public int module;
    public GameObject[] Panels;

    public int quiz1;
    void Start()
    {
        
        os_score = PlayerPrefs.GetInt("Os_scorekey", os_score);
        quiz1= PlayerPrefs.GetInt("Os_quiz1", quiz1);
        os_show.text = os_score.ToString();
        docker_score = PlayerPrefs.GetInt("docker_scorekey", docker_score);
        kub_score = PlayerPrefs.GetInt("kub_scorekey", kub_score);
        docker_score_show.text = docker_score.ToString();
        if (os_score == 20)
        {
            btn1.interactable = true;
            btn2.interactable = true;

            Btn1.SetActive(true);
            Btn2.SetActive(true);
        }
        if (docker_score == 10)
        {
            btn1.interactable = true;
            btn2.interactable = true;
            btn3.interactable = true;

            Btn1.SetActive(true);
            Btn2.SetActive(true);
            Btn3.SetActive(true);
        }

        if (quiz1 == 1)
        {
            GameController.islearning = false;
        }
        else
        {
            GameController.islearning = true;
        }
           
    }

    // Update is called once per frame
    void FixedUpdate()
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
            if (hit.collider.gameObject.name == "back")
            {
                Panels[0].SetActive(true);
                Panels[1].SetActive(false);
                module = 0;
            }
            if (hit.collider.gameObject.name == "btn1")
            {
                Panels[0].SetActive(false);
                Panels[1].SetActive(true);
                module = 1;
            }
            if (hit.collider.gameObject.name == "btn2")
            {
                Panels[0].SetActive(false);
                Panels[1].SetActive(true);
                module = 2;
            }
            if (hit.collider.gameObject.name == "btn3")
            {
                Panels[0].SetActive(false);
                Panels[1].SetActive(true);
                module = 3;
            }
            if (hit.collider.gameObject.name == "learn")
            {
                if (module == 1)
                {
                    On_os();
                    GameController.islearning = true;
                    raycast_hit.isquiz2 = false;
                }
                if (module == 2)
                {
                    On_docker();
                }
                if (module == 3)
                {
                    On_kubernetes();
                    kuberbetes.islearn_1 = true;
                }
            }
            if (hit.collider.gameObject.name == "quiz")
            {
                if (module == 1)
                {
                    On_os();
                    Os_quiz();
                    
                }
                if (module == 2)
                {
                    On_docker();
                    Docker_quiz();
                }
                if (module == 3)
                {
                    //On_kubernetes();
                    kubernetes_quiz();
                }
            }

            if (hit.collider.gameObject.name == "reset")
            {
                ResetScore();
            }
            if (hit.collider.gameObject.name == "score")
            {
                Application.LoadLevel(4);
            }
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }

    public void On_os()
    {
        Application.LoadLevel(1);
        
    }
    public void On_docker()
    {
        Application.LoadLevel(2);

    }
    public void On_kubernetes()
    {
        Application.LoadLevel(3);
        kuberbetes.islearn_1 = true;

    }
    public void kubernetes_quiz()
    {
        Application.LoadLevel(3);
        kuberbetes.islearn_1 = false;

    }
    public void Os_quiz()
    {
        raycast_hit.isquiz2 = true;
        if (quiz1 == 1)
        {
            GameController.islearning = false;
        }
        else
        {
            GameController.islearning = true;
        }
        
    }
    public void Docker_quiz()
    {
        docker_raycast.isQuiz = true;
    }
    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        Application.LoadLevel(0);
    }
   
}
