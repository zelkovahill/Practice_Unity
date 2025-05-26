using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel _playerModel;
        private PlayerView _playerView;

        private void Awake()
        {
            _playerView = GetComponent<PlayerView>();

            _playerModel = new PlayerModel(100);
            _playerModel.OnHealthChanged += _playerView.UpdateHealthBar;
        }

        private void OnDestroy()
        {
            if (_playerModel != null)
            {
                _playerModel.OnHealthChanged -= _playerView.UpdateHealthBar;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                DamagePlayer();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                HealPlayer();
            }
        }

        private void DamagePlayer()
        {
            _playerModel.TakeDamage(10);
        }

        private void HealPlayer()
        {
            _playerModel.Heal(10);
        }
    }
}
