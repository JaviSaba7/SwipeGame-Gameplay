using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject ball;
    public GameObject particles_explosion;
    public GameObject mecha;
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
            ball.GetComponent<SphereCollider>().radius = 2;

            Debug.Log("explosion");

            particles_explosion.SetActive(true);

            ball.GetComponent<MeshRenderer>().enabled = false;
            //add a delay to destroy de collider???
            ball.GetComponent<SphereCollider>().enabled = false;

            mecha.SetActive(false);

        }
    }
}
