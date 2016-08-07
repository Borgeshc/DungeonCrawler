using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{
	public int damagePerShot = 20;                  
	public float timeBetweenBullets = 0.15f;        
	public float range = 100f;                      
	
	float timer;                                  
	Ray shootRay;                                   
	RaycastHit hit;                            
	int shootableMask;                              
	LineRenderer bullet;                           
	AudioSource gunAudio;                         
	Light muzzleFlash;                                 
	float effectsDisplayTime = 0.2f;               
	
	void Awake ()
	{
		bullet = GetComponentInChildren <LineRenderer> ();
		gunAudio = GetComponentInChildren<AudioSource> ();
		muzzleFlash = GetComponentInChildren<Light> ();
	}
	
	void Update ()
	{
		timer += Time.deltaTime;
		if(Input.GetButton ("Fire1") && timer >= timeBetweenBullets)
		{
			Shooting ();
		}
		
		if(timer >= timeBetweenBullets * effectsDisplayTime)
		{
			StopShooting ();
		}
	}
	
	public void StopShooting ()
	{
		bullet.enabled = false;
		muzzleFlash.enabled = false;
	}
	
	void Shooting ()
	{
		timer = 0f;
		gunAudio.Play ();
		muzzleFlash.enabled = true;
		
		bullet.enabled = true;
		bullet.SetPosition (0, transform.position);
		
		shootRay.origin = transform.position;
		shootRay.direction = transform.forward;
		
		if(Physics.Raycast (shootRay, out hit, range))
		{
			if(hit.collider.tag == "Enemy")
			{
				hit.transform.GetComponent <EnemyHealth> ().TookDamage (damagePerShot);
				bullet.SetPosition (1, hit.point);
			}
		}
		else
		{
			bullet.SetPosition (1, shootRay.origin + shootRay.direction * range);
		}

	}
}	