using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateMethod
{
    public class Player : MonoBehaviour
    {
        private int _life = 10;

        public void ApplyDamage(int damage)
        {
            _life -= damage;
            Debug.Log($"[Player] 피해: {damage}, 현재 체력: {_life}");
        }

        public void ApplyHeal(int heal)
        {
            _life += heal;
            Debug.Log($"[Player] 회복: {heal}, 현재 체력: {_life}");
        }
    }
}
