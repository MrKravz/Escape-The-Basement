using System;
using UnityEngine;

namespace Assets.Scripts.ConundrumScripts
{
    public abstract class InteractableConundrum : Conundrum, IInteractable
    {

        public void Interact(GameObject gameObject)
        {
            Solve(gameObject);
        }
    }
}
