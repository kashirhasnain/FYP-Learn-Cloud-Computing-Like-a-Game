using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.XR;
public class DataBase : MonoBehaviour {
	//Sign In
	public InputField login_username;
	public InputField login_pwd;

	//Sign up
	public InputField signup_username;
	public InputField signup_pwd;
	public InputField signup_Re_pwd;
	public Text message_text;

	public GameObject signup_panel;
    public GameObject signin_panel;


 
	int data_index;
	bool account=false;
	string name="";
 

	string password="";

    
	public void CreateAccount()
	{
		

		// Validation
		if (signup_pwd.text.Length > 3) {
			name = signup_username.text;
			account = true;
				
		} else {
			message_text.text="Please Enter Username";
			account = false;
		
		}
		if (signup_pwd.text == signup_Re_pwd.text) {
		
			password = signup_pwd.text;
			account = true;

		} else {
			message_text.text="Password Does not Match";
			account = false;
		}

		//Create Account
		if (account == true) {
			data_index = PlayerPrefs.GetInt ("index");
 			data_index += 1;
			PlayerPrefs.SetString ("password"+data_index.ToString(), password);
			PlayerPrefs.SetString ("name"+data_index.ToString(), name);
			PlayerPrefs.SetInt ("index", data_index);
    //  
			print (name);
	 		print (password);
			message_text.text="Account Successfully Created";
		}

	}
	public void Login_page()
	{
		signup_panel.SetActive(false);
		signin_panel.SetActive(true);
	}
    void Start () {
        signup_panel.SetActive(false);
        signin_panel.SetActive(true);
        XRSettings.LoadDeviceByName("");
        XRSettings.enabled = false;


    }
    public void signup_Btn()
    {
        signup_panel.SetActive(true);
        signin_panel.SetActive(false);
    }
    public void Signin_Btn()
    {
		  name = login_username.text;
	   password = login_pwd.text;
		data_index=PlayerPrefs.GetInt("index");
		for (int i = 0; i <= data_index; i++) {
		
			if (name ==  PlayerPrefs.GetString ("name"+i.ToString())&&password==PlayerPrefs.GetString ("password"+i.ToString())) {
			string Getname = PlayerPrefs.GetString ("name"+i.ToString());
			string Getpwd =  PlayerPrefs.GetString ("password"+i.ToString());
		print ("Username: " + Getname + "  Password: " + Getpwd);//+"   index: "+data_index);
			print("logintextbox: "+name);
                XRSettings.LoadDeviceByName("cardboard");
                XRSettings.enabled = true;
                Application.LoadLevel(1);

				}

 		}

		 
	
	 
    }
     
	// Update is called once per frame
	void Update () {

	}
    
}
