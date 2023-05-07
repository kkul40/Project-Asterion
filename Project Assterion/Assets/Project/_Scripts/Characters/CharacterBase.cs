using System;
using UnityEngine;

namespace Project._Scripts.Characters
{
    [SelectionBase]
    public abstract class CharacterBase : MonoBehaviour
    {
        [SerializeField] protected int health;
        public int maxHealth;

        protected virtual void Start()
        {
            health = maxHealth;
        }
    }
}