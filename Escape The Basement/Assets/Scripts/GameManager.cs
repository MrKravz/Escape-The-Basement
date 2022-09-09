using Assets.Scripts.ConundrumScripts;
using Assets.Scripts.PlayerScripts;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerInteractionModel player;
    [SerializeField] private DelayedConundrum conundrum;

    private void Awake()
    {
        player.OnKeyStateChange += () => { conundrum.ChangeInteractionState(player.HasKey); };
    }
}
