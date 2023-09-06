using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Entity : MonoBehaviour {
    private int maxHealth;
    private int maxMana;
    private int currentHealth;
    private int currentMana;
    private int armor;

    public int Health {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

    public int Mana {
        get { return currentMana; }
        set { currentMana = value; }
    }

    public int Armor {
        get { return armor; }
        set { armor = value; }
    }

    [SerializeField]
    private Entity entity;

    [SerializeField]
    private Class entityClass;

    private void Awake() {
        entity = GetComponent<Entity>();
        maxHealth = entity.GetMaxHealth();
    }

    private int GetMaxHealth() {
        return 1;//entityClass.MaxHealth;
    }

    private void TakeDamage(int amount) {
        if (armor > 0) {

        } else {

        }
    }

    private void Heal(int amount) {
        if (amount + currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    }

    private void UseMana(int amount) {

    }
}
