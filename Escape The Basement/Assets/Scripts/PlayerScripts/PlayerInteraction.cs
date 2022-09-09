using Assets.Scripts.ConundrumScripts;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public class PlayerInteraction : MonoBehaviour
    {
        [SerializeField] private Camera PlayerMainCamera = default;
        [SerializeField] private float interactionDistance = default;
        [SerializeField] private LayerMask RaycastMask = default;

        void LateUpdate()
        {
            RaycastHit raycastHit = default;
            if (Physics.Raycast(PlayerMainCamera.transform.position, PlayerMainCamera.transform.forward, out raycastHit, interactionDistance, RaycastMask))
            {
                if (raycastHit.collider != null)
                {
                    var interactivableInterface = raycastHit.collider.GetComponent<IInteractable>();
                    if (interactivableInterface != null)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Debug.Log("3");
                            interactivableInterface?.Interact(gameObject);
                        }
                    }
                }
            }
        }
    }
}
