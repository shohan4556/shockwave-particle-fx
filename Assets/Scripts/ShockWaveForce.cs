using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockWaveForce : MonoBehaviour {

	public float radius = 10f;
	public float force = 5f;
	public ParticleSystem postShockFX;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		
	}

	void ShockWave()
	{
		Vector3 pos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

		foreach(Collider col in colliders){
			rigidbody = col.GetComponent<Rigidbody>();
			if(rigidbody!=null){
				rigidbody.AddExplosionForce(force, pos, radius);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(postShockFX.isPlaying){
			ShockWave();
		}	
	}

}
