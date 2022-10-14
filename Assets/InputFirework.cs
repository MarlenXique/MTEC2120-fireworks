using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class InputFirework : MonoBehaviour
{
    int index = 0;
    [SerializeField] List<GameObject> fireworks = new List<GameObject>();
    PlayerInputManager manager;

    private void Start()
    {
        manager = GetComponent<PlayerInputManager>();
        index = Random.Range(0, fireworks.Count);
        manager.playerPrefab = fireworks[index];

    }


    public void Switch(InputAction.CallbackContext context)
    {
        index = Random.Range(0, fireworks.Count);
        manager.playerPrefab = fireworks[index];

    }
}
