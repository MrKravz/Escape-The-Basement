using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts.ConundrumScripts.Conundrums
{
    public class Chest : DelayedConundrum
    {
        protected override void Solve(GameObject gameObject)
        {
            Debug.Log("4");
            if (gameObject != null)
            {
                Debug.Log("2");
                if (gameObject.TryGetComponent<PlayerInteractionModel>(out var a))
                {
                    Debug.Log("1");
                    _isSolved = a.HasKey;
                }
            }
        }
    }
}
