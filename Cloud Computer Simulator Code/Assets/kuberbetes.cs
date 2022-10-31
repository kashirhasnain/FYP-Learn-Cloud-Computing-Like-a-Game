using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kuberbetes : MonoBehaviour
{
    // Start is called before the first frame update
    public int visiters;
    public int filesize;
    public Text visitershow,sizeshow;
    public GameObject[] containers;
    public Material green;

    public GameObject server,limitpanel;
    public bool isserverbuy;
    public bool islearn;
    public static bool islearn_1;
    public static kuberbetes kuberbetes_;
    public void Start()
    {
        islearn = islearn_1;
        kuberbetes_ = this;
      visiters = Random.Range(0, 300);
       filesize = Random.Range(1, 1500);

        visitershow.text = visiters.ToString();
        sizeshow.text = filesize.ToString();
        if (islearn)
        {
            On_server();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void On_server()
    {
        visitershow.text = visiters.ToString();
        sizeshow.text = filesize.ToString();
        if (visiters <= 10)
        {

        }
        else if (visiters > 10 && visiters <= 20)
        {
            containers[1].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 20 && visiters <= 30)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 30 && visiters <= 40)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 40 && visiters <= 50)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 50 && visiters <= 60)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 60 && visiters <= 70)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 70 && visiters <= 80)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 80 && visiters <= 90)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 90 && visiters <= 100)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 100 && visiters <= 110)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 110 && visiters <= 120)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 120 && visiters <= 130)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 130 && visiters <= 140)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 140 && visiters <= 150)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 150 && visiters <= 160)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 160 && visiters <= 170)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
            containers[16].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 170 && visiters <= 180)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
            containers[16].GetComponent<Renderer>().material = green;
            containers[17].GetComponent<Renderer>().material = green;
        }
        else if (visiters > 180 && visiters <= 190)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 190 && visiters <= 200)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 200 && visiters <= 210)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 210 && visiters <= 220)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 220 && visiters <= 230)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 230 && visiters <= 240)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 240 && visiters <= 250)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 250 && visiters <= 260)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 260 && visiters <= 270)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 270 && visiters <= 280)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 280 && visiters <= 290)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
                containers[28].GetComponent<Renderer>().material = green;
            }
        }
        else if (visiters > 290 && visiters <= 300)
        {
            print("Server visitors limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
                containers[28].GetComponent<Renderer>().material = green;
                containers[29].GetComponent<Renderer>().material = green;
            }
        }
        /****************
         * **********/

        if (filesize <= 50)
        {

        }
        else if (filesize > 50 && filesize <= 100)
        {
            containers[1].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 100 && filesize <= 150)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 150 && filesize <= 200)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 200 && filesize <= 250)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 250 && filesize <= 300)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 300 && filesize <= 350)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 350 && filesize <= 400)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 400 && filesize <= 450)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 450 && filesize <= 500)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 500 && filesize <= 550)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 550 && filesize <= 600)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 600 && filesize <= 650)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 650 && filesize <= 700)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 700 && filesize <= 750)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 750 && filesize <= 800)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 800 && filesize <= 850)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
            containers[16].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 850 && filesize <= 900)
        {
            containers[1].GetComponent<Renderer>().material = green;
            containers[2].GetComponent<Renderer>().material = green;
            containers[3].GetComponent<Renderer>().material = green;
            containers[4].GetComponent<Renderer>().material = green;
            containers[5].GetComponent<Renderer>().material = green;
            containers[6].GetComponent<Renderer>().material = green;
            containers[7].GetComponent<Renderer>().material = green;
            containers[8].GetComponent<Renderer>().material = green;
            containers[9].GetComponent<Renderer>().material = green;
            containers[10].GetComponent<Renderer>().material = green;
            containers[11].GetComponent<Renderer>().material = green;
            containers[12].GetComponent<Renderer>().material = green;
            containers[13].GetComponent<Renderer>().material = green;
            containers[14].GetComponent<Renderer>().material = green;
            containers[15].GetComponent<Renderer>().material = green;
            containers[16].GetComponent<Renderer>().material = green;
            containers[17].GetComponent<Renderer>().material = green;
        }
        else if (filesize > 900 && filesize <= 950)
        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 950 && filesize <= 1000)
        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1000 && filesize <= 1050)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1050 && filesize <= 1100)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1100 && filesize <= 1150)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1150 && filesize <= 1200)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1200 && filesize <= 1250)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1250 && filesize <= 1300)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1300 && filesize <= 1350)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1350 && filesize <= 1400)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1400 && filesize <= 1450)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
                containers[28].GetComponent<Renderer>().material = green;
            }
        }
        else if (filesize > 1450 && filesize <= 1500)

        {
            print("Server limit reached");
            server.gameObject.SetActive(false);
            limitpanel.SetActive(true);
            if (isserverbuy == true)
            {
                containers[1].GetComponent<Renderer>().material = green;
                containers[2].GetComponent<Renderer>().material = green;
                containers[3].GetComponent<Renderer>().material = green;
                containers[4].GetComponent<Renderer>().material = green;
                containers[5].GetComponent<Renderer>().material = green;
                containers[6].GetComponent<Renderer>().material = green;
                containers[7].GetComponent<Renderer>().material = green;
                containers[8].GetComponent<Renderer>().material = green;
                containers[9].GetComponent<Renderer>().material = green;
                containers[10].GetComponent<Renderer>().material = green;
                containers[11].GetComponent<Renderer>().material = green;
                containers[12].GetComponent<Renderer>().material = green;
                containers[13].GetComponent<Renderer>().material = green;
                containers[14].GetComponent<Renderer>().material = green;
                containers[15].GetComponent<Renderer>().material = green;
                containers[16].GetComponent<Renderer>().material = green;
                containers[17].GetComponent<Renderer>().material = green;
                containers[18].GetComponent<Renderer>().material = green;
                containers[19].GetComponent<Renderer>().material = green;
                containers[20].GetComponent<Renderer>().material = green;
                containers[21].GetComponent<Renderer>().material = green;
                containers[22].GetComponent<Renderer>().material = green;
                containers[23].GetComponent<Renderer>().material = green;
                containers[24].GetComponent<Renderer>().material = green;
                containers[25].GetComponent<Renderer>().material = green;
                containers[26].GetComponent<Renderer>().material = green;
                containers[27].GetComponent<Renderer>().material = green;
                containers[28].GetComponent<Renderer>().material = green;
                containers[29].GetComponent<Renderer>().material = green;
            }
        }
    }
}
