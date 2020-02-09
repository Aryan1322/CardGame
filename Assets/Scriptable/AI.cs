using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public FloatRefrence maxHealth, speed, attackCooldown;

    private void Update()
    {
        Debug.Log(maxHealth.Value);
        Debug.Log(speed.Value);
        Debug.Log(attackCooldown.Value);
    }
}
