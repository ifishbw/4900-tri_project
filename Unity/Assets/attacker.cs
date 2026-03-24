using UnityEngine;
using UnityEngine.InputSystem;

public class attacker : MonoBehaviour
{
    InputAction attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if (attack.IsPressed())
            Debug.Log("Attacked!!");
    }
}
