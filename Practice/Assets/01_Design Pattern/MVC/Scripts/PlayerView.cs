using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Slider _healthBar;

        public void UpdateHealthBar(int current, int max)
        {
            if (_healthBar != null)
            {
                _healthBar.value = (float)current / max;
            }
        }
    }
}
