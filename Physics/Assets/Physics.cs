using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {
    
    // Use this for initialization
	void Start () {
		
	}
    void FixedUpdate()
    {
    }
        void OnCollisionEnter(Collision other)
        {
            //Debug.Log("i touched something!!");
            Debug.Log(other.gameObject.tag);
            if (other.gameObject.tag == "Sphere")
            {

                gameObject.GetComponent<Renderer>().material.color = Color.green;


            }
        }
        void OnCollisionStay(Collision other)
        {
            //Debug.Log("i'm still touching!!");
            if (other.gameObject.tag == "Sphere") {

                gameObject.GetComponent<Renderer>().material.color = Color.green;
                GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
            }
        }
        void OnCollisionExit(Collision other)
        {
            //Debug.Log("no longer touching");
            if (other.gameObject.tag == "Sphere")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }

    
  
    public float upforce;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);
    }

    void OnTriggerEnter (Collider other)
    {

    }
    void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
        GetComponent<Rigidbody>().AddTorque(Vector3.up * upforce);


    }
    void OnTriggerExit(Collider other)
    {

    }



}
