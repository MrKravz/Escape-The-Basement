using UnityEngine;

namespace Assets.Scripts.ConundrumScripts
{
    public abstract class DelayedConundrum : Conundrum, IDelayedInteractable
    {
        protected bool _isCanInteract = default;
        public bool IsCanInteract => _isCanInteract;

        public void ChangeInteractionState(bool interactionState)
        {
            _isCanInteract = interactionState;
        }

        public void Interact(GameObject gameObject)
        {
            if (IsCanInteract)
            {
                Solve(gameObject);
            }
        }
    }
}
