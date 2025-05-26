using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class PlayerModel
    {
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public event Action<int, int> OnHealthChanged;

        public PlayerModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);

            if (OnHealthChanged != null)
            {
                OnHealthChanged(CurrentHealth, MaxHealth);
            }
        }

        public void Heal(int amount)
        {
            CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);

            if (OnHealthChanged != null)
            {
                OnHealthChanged(CurrentHealth, MaxHealth);
            }
        }
    }
}
