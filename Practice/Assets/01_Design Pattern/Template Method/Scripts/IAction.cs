using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TemplateMethod
{
    public interface IAction
    {
        void Execute(Player player);
    }

    public class DamageAction : IAction
    {
        private int _damageAmount;

        public DamageAction(int damage)
        {
            _damageAmount = damage;
        }

        public void Execute(Player player)
        {
            player.ApplyDamage(_damageAmount);
        }
    }

    public class HealAction : IAction
    {
        private int _healAmount;

        public HealAction(int heal)
        {
            _healAmount = heal;
        }

        public void Execute(Player player)
        {
            player.ApplyHeal(_healAmount);
        }
    }
}
