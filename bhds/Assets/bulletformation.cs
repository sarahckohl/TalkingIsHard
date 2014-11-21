using UnityEngine;
using System.Collections;

public class bulletformation : MonoBehaviour {
	public GameObject bullet;
	public Transform bulletEmitter;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartBulletPattern ());

	}
	
	// Update is called once per frame
	void Update () {

		//Instantiate (bullet, bulletEmitter.position, bulletEmitter.rotation);


	}

	IEnumerator StartBulletPattern(){
		StartCoroutine (ShootBullet (10,.1f));
		yield return new WaitForSeconds(1.0f);
		StartCoroutine(StartBulletPattern());
		}

	IEnumerator ShootBullet(int shotNum, float timeShot){
		int i = shotNum;
		float bulletRot = bulletEmitter.eulerAngles.y;
		   
		while (i>0) {

			Instantiate (bullet, bulletEmitter.position, Quaternion.Euler (0, 0, bulletRot));
			bulletRot -= 360.0f/shotNum;
			yield return new WaitForSeconds(timeShot/shotNum); 
			i--;
				}
		yield return new WaitForSeconds(0);
	}
}
