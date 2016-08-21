using UnityEngine;
using System.Collections;

public class EnemyInRange : MonoBehaviour
{
    public string enemyTag;

    public int range;

    GameObject target;
    bool targetFound;
    float distance;

    void Update()
    {

        target = GameObject.FindGameObjectWithTag(enemyTag);
        if (target != null)
        {
            FoundTarget();
            distance = Vector3.Distance(transform.parent.position, target.transform.position);
        }

    }

    void FoundTarget()
    {
        if (distance > 0 && distance < range)
        {
            transform.parent.FindChild("Gun").gameObject.SetActive(true);
            transform.parent.GetComponent<Turret>().enabled = true;
           // transform.parent.GetComponent<Turret>().SetTarget(target);
        }
        else
        {
            //transform.parent.GetComponent<Turret>().enabled = false;
            transform.parent.FindChild("Gun").gameObject.SetActive(false);
        }
    }
}
