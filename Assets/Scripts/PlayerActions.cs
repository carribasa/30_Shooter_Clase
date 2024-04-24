using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] Transform weaponPosition;

    void Start()
    {

    }

    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire"))
        {
            
        }
    }
}
