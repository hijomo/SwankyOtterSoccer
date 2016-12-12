using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScipt : MonoBehaviour {


  public GameObject otterInstance, particalInstance;
  AudioSource au;
	// Use this for initialization
	void Start () {
    au = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject == GameObject.FindGameObjectWithTag("Otter"))
    {
      Instantiate(particalInstance, other.transform.position,other.transform.rotation);
      Instantiate(otterInstance, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
      au.Play();
      Destroy(other.gameObject);
    }
    
  }

}
