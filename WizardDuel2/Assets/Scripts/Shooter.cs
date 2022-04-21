using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{

    public Camera cam;
    public GameObject projectile;
    public Transform firePoint;

    public float projectileSpeed = 30f;
    public float fireRate = 4;

    public float arcRange = 1;

    private Vector3 destination;
    private float timeToFire;

 [SerializeField]
    private InputActionReference m_ActionReference;
    public InputActionReference actionReference { get => m_ActionReference ; set => m_ActionReference = value; }

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
      if (actionReference != null && actionReference.action != null)
            {

            if (actionReference.action.ReadValue<float>() == 1 && Time.time >= timeToFire)
            {
                timeToFire = Time.time + 1/fireRate;
                ShootProjectile();
            }
        }
    }

    void ShootProjectile() 
    {
        Ray ray = new Ray(firePoint.position, -firePoint.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else {
            destination = ray.GetPoint(1000);
        }
        IntantiateProjectile();
    }

    void IntantiateProjectile()
    {
        var projectileObject = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;

        projectileObject.GetComponent<Rigidbody>().velocity = -(destination - firePoint.position).normalized *  projectileSpeed;

        iTween.PunchPosition(projectileObject,new Vector3(UnityEngine.Random.Range(-arcRange,arcRange), UnityEngine.Random.Range(-arcRange,arcRange), 0), UnityEngine.Random.Range(0.5f,2));
    }
}
