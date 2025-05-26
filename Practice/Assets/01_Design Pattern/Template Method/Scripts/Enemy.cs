using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateMethod
{
    public abstract class Enemy : MonoBehaviour
    {
        protected IAction _action;
        private Player _player;

        public abstract void Initialize(IAction action);

        public void Attack()
        {
            ApproachPlayer();
            PerformAction();
            Retreat();
        }

        protected virtual void ApproachPlayer()
        {
            Debug.Log("[Enemy] 적이 플레이어한테 접근합니다.");
        }

        protected virtual void PerformAction()
        {
            _action.Execute(_player);
        }

        protected virtual void Retreat()
        {
            Debug.Log("[Enemy] 적이 후퇴합니다.");
        }

        public void SetPlayer(Player player)
        {
            _player = player;
        }
    }

    public class DamageEnemy : Enemy
    {
        public override void Initialize(IAction action)
        {
            this._action = action;
        }
    }


    public class HealEnemy : Enemy
    {
        public override void Initialize(IAction action)
        {
            this._action = action;
        }
    }
}
