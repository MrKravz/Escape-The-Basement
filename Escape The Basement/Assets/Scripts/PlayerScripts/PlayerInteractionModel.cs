using Assets.Scripts.ClueScripts;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{

    public class PlayerInteractionModel : MonoBehaviour
    {
        [field: SerializeField] public bool HasKey { get; private set; } = default;

        public event Action OnKeyStateChange;

        

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                HasKey = !HasKey;
                OnKeyStateChange?.Invoke();
            }
        }
    }
}