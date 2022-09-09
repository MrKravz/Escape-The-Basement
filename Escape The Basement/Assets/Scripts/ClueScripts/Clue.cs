using Assets.Scripts.ConundrumScripts;
using UnityEngine;

namespace Assets.Scripts.ClueScripts
{
    public class Clue : MonoBehaviour, IClue
    {
        [SerializeField] protected Conundrum _conundrum;
        public void ShowClue()
        {

        }
    }
}