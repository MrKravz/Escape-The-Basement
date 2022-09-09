using System;
using UnityEngine;

namespace Assets.Scripts.ConundrumScripts.Conundrums
{
    public class Book : InteractableConundrum
    {
        protected override void Solve(GameObject gameObject)
        {
            _isSolved = true;
        }
    }
}
