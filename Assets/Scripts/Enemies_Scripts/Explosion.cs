using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject ball;
    public GameObject particles_explosion;
    public GameObject mecha;
    public float counter = 0;
    public bool counterActive = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 if(counterActive) counter++;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ground")
        {
            counterActive = true;
            if (counter >= 1000)
            {
                ball.GetComponent<SphereCollider>().enabled = false;
                Debug.Log("DELETE");

            }

            ball.GetComponent<SphereCollider>().radius = 5;

            Debug.Log("explosion");

            particles_explosion.SetActive(true);

            ball.GetComponent<MeshRenderer>().enabled = false;
            //add a delay to destroy de collider???

            mecha.SetActive(false);

        }
    }
}
