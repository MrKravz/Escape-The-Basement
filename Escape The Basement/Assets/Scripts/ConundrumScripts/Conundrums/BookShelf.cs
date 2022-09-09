using UnityEngine;

namespace Assets.Scripts.ConundrumScripts.Conundrums
{
    public class BookShelf : InteractableConundrum
    {
        protected override void Solve(GameObject gameObject)
        {
            _isSolved = true;
        }
    }
}