namespace Assets.Scripts.ConundrumScripts
{
    public interface IDelayedInteractable : IInteractable
    {
        public bool IsCanInteract { get; }

        public void ChangeInteractionState(bool interactionState);
    }
}
