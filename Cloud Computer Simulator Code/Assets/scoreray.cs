using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreray : MonoBehaviour
{
    // Start is called before the first frame update
    public int os_score1;
    public int docker_score1;
    public int kub_score1;

    public Text s1, s2, s3;
    void Start()
    {
        os_score1 = PlayerPrefs.GetInt("Os_scorekey");
        docker_score1 = PlayerPrefs.GetInt("docker_scorekey");
        kub_score1 = PlayerPrefs.GetInt("kub_scorekey");
        s1.text = os_score1.ToString();
        s2.text = docker_score1.ToString();
        s3.text = kub_score1.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider.gameObject.name == "back")
            {
                Application.LoadLevel(0);
            }
            if (hit.collider.gameObject.name == "reset")
            {
                PlayerPrefs.DeleteAll();
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

}
