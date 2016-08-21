using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public int damagePerShot = 20;
    public int targetRange;

    public float timeBetweenBullets = 0.15f;
    public float range = 100f;

    public string targetTag;

    GameObject target;
    GameObject newTarget;
    int shootableMask;
    float distance;
    float effectsDisplayTime = 0.2f;
    float timer;
    bool targetFound;

    AudioSource gunAudio;
    LineRenderer bullet;
    RaycastHit hit;
    Light muzzleFlash;
    Ray shootRay;



    void Awake()
    {
        bullet = GetComponentInChildren<LineRenderer>();
        gunAudio = GetComponentInChildren<AudioSource>();
        muzzleFlash = GetComponentInChildren<Light>();
    }



    void Update()
    {
        target = GameObject.FindGameObjectWithTag(targetTag);
        distance = Vector3.Distance(transform.position, target.transform.position);

        timer += Time.deltaTime;

        if (timer >= timeBetweenBullets && distance > 0 && distance < targetRange) //Call shooting on target found and not dead and timer >= timeBetweenBullets
        {
            newTarget = target;
            Shooting();
        }


        if (timer >= timeBetweenBullets * effectsDisplayTime) //if target died stop shooting
        {
            StopShooting();
        }
    }

    public void StopShooting()
    {
        bullet.enabled = false;
        muzzleFlash.enabled = false;
    }

    void Shooting()
    {
        timer = 0f;
        gunAudio.Play();
        muzzleFlash.enabled = true;

        bullet.enabled = true;
        bullet.SetPosition(0, transform.position);

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;
        if (newTarget != null)
        {
            transform.LookAt(newTarget.transform);
        }

        if (Physics.Raycast(shootRay, out hit, range))
        {
            if (hit.collider.tag == targetTag)
            {
                hit.transform.GetComponent<EnemyHealth>().TookDamage(damagePerShot);
                bullet.SetPosition(1, hit.point);
            }
        }
        else
        {
            bullet.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }

    }
}	