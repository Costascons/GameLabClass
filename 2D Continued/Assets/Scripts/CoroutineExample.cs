using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("myCoroutine");
	}
	
   IEnumerator myCoroutine()
    {   //do something
        yield return new WaitForSeconds(2);
        //do something else
        yield return null;


    }
}
