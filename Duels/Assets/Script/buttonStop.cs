using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonStop : MonoBehaviour {
    public Value val;
    public GameObject bulletPrefarb;
    public Transform bulletSpawn;


    public TimeManager timeManager;
    public ParticleSystem Death;
    public ParticleSystem bulletFlash;
	// Use this for initialization
	void Start () {
		
	}

    public void Stop()
    {
        val.TimeActive = false;

        if (val.nilai == 0)
        {
            Debug.Log("0% = 0");
            FireFire();
        }
        else if (val.nilai <= 0.4 )
        {
            Debug.Log("25% = 0.4");
            FireFire();
        }
        else if (val.nilai <= 0.5)
        {
            Debug.Log("50% = 0.5");
            FireFire();
        }
        else if (val.nilai <= 0.8)
        {
            Debug.Log("50%  = 0.8");
            FireFire();
        }
        else if (val.nilai <= 0.9)
        {
            Debug.Log("100% = 0.9");
            FireFire();
        }
        else if (val.nilai <= 1.1)
        {
           Debug.Log("100% = 1.1");
           FireFire();
        }
        else if (val.nilai <= 1.2)
        {
            Debug.Log("50%  = 1.2");
            FireFire();
        }
        else if (val.nilai <= 1.6)
        {
            Debug.Log("50% = 1.6");
            FireFire();
        }
        else if (val.nilai <= 1.7)
        {
            Debug.Log("25% <= 1.7");
            FireFire();
        }
        else if (val.nilai <= 2)
        {
            Debug.Log("0% = 2");
            FireFire();
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
    public void FireFire()
    {

        Death.Play();
        bulletFlash.Play();
        //Death.Emit(1);
        
        
        var bullet = (GameObject)Instantiate(bulletPrefarb, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 38;

        timeManager.DoSlowMotion();
        Destroy(bullet, 15.0f);
    }
}
