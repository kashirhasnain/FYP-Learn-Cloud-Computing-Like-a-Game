using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quizer : MonoBehaviour
{
    public int Quiz;
    public int Questions;
    public Text quizq;
    public int qpro, qram, qhard;
    public Text qpro_show, qram_show, qhard_show;
    // Start is called before the first frame update
    void Start()
    {
        if (Quiz == 1)
        {
            if (Questions == 1)
            {
                quizq.text = "Q: You have 3 Os in virtual box config your all Os With given SP of PC.";
                qpro = 16;
                qram = 8;
                qhard = 4;
                qpro_show.text = qpro.ToString();
                qram_show.text = qram.ToString();
                qhard_show.text = qhard.ToString();

            }
            if (Questions == 2)
            {
                quizq.text = "Q: You have 2 Os in virtual box config your all Os With given SP of PC.";
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
