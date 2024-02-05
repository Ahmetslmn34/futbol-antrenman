using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kodlar : MonoBehaviour
{
    public Animator animatorum;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
            animatorum.SetBool("yuru", true);
        }
        if (Input.GetKeyUp("w"))
        {
            animatorum.SetBool("yuru", false);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 10);
            animatorum.SetBool("yuru", true);
        }
        if (Input.GetKeyUp("a"))
        {
            animatorum.SetBool("yuru", false);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 10);
            animatorum.SetBool("yuru", true);
        }
        if (Input.GetKeyUp("s"))
        {
            animatorum.SetBool("yuru", false);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 10);
            animatorum.SetBool("yuru", true);
        }
        if (Input.GetKeyUp("d"))
        {
            animatorum.SetBool("yuru", false);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 10);
            animatorum.SetBool("zipla", true);
        }
        if (Input.GetKeyUp("space"))
        {
            animatorum.SetBool("zipla", false);
        }
    }

}
