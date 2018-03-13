using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject ball;
    public GameObject particles_explosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            Debug.Log("explosion");
            ball.GetComponent<SphereCollider>().radius = 2;

            particles_explosion.SetActive(true);
            ball.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
