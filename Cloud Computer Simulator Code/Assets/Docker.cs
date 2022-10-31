using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Docker : MonoBehaviour
{
    public Text size_val;
    public Text location_show, Version_show,errorshow;
    public InputField location_val, Version_val;
    public bool isdocker;
    public string[] filelocation;
    public int filerand;

    public static Docker docker_fake;
    // Start is called before the first frame update
    void Start()
    {
        docker_fake = this;
        filerand=Random.Range(0, 3);
        location_val.text = filelocation[filerand];
    }

    // Update is called once per frame
    void Update()
    {
        Version_val.text = docker_raycast.versionval_;
    }
    public void Onwithdocker()
    {
        size_val.text = "2.5 MB";
        location_show.text = filelocation[filerand];
        Version_show.text = docker_raycast.versionval_;
        isdocker = true;
    }
    public void Onwithoutdocker()
    {
        size_val.text = "5 MB";
        location_show.text = filelocation[filerand];
        Version_show.text = docker_raycast.versionval_;
        isdocker = false;
    }
    public void OnSave()
    {
        
    }
    public void Onyes()
    {
        if (isdocker)
        {
            errorshow.text = "version donst matter";
        }
        else
        {
           
            errorshow.text = "version error";
        }
    }
}
