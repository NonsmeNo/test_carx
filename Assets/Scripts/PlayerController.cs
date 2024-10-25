using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FreeCamera freeCamera;
    public GameObject ui;

    public StoneSpawner stoneSpawner;

    void Update()
    {
        
        if (freeCamera != null)
        {
            freeCamera.Move();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            stoneSpawner.Spawn();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            
        }
    }
}
