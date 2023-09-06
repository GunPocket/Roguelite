using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : Class {
    [SerializeField]
    private int maxHealth;

    public int MaxHealth {
        get { return maxHealth; }
    }
}
