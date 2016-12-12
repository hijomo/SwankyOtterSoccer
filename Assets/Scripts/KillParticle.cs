using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillParticle : MonoBehaviour {


  float killTime;
	// Use this for initialization
	void Start () {
    killTime = Time.time+4.0f;
	}
	
	// Update is called once per frame
	void Update () {
    if (Time.time > killTime)
      Destroy(this.gameObject);
		
	}
}
