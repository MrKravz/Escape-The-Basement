using UnityEngine;

namespace Assets.Scripts.ConundrumScripts
{
    public abstract class Conundrum : MonoBehaviour
    {
        protected bool _isSolved = default;

        protected abstract void Solve(GameObject gameObject);
    }
}