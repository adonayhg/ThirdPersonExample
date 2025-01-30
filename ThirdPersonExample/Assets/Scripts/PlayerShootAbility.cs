using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;


public class PlayerShootAbility : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public GenericPool bulletPool;

    private void Awake()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckShoot();
    }

    void CheckShoot()
    {
        if(_input.shoot)
        {
            Debug.Log("Dispara");
            GameObject bullet = bulletPool.GetElementFromPool();
            bullet.SetActive(true);
            bullet.transform.position = transform.position + transform.up * 0.5f + transform.forward * 0.5f;

            //Release del boton
            _input.shoot = false;
        }
    }
}
