using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _playerMoveSpeed;
        [SerializeField] private float _playerRotationSpeed;
        [SerializeField] private FloatingJoystick _joystick;
        private Rigidbody _playerRb;
        private Vector3 _playerMoveVelocity;
        private Vector3 _playerInput;

        private void Awake()
        {
            _playerRb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _playerInput = new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical);
            _playerMoveVelocity = _playerInput * _playerMoveSpeed;
            _playerRb.MovePosition(transform.position + transform.forward * _playerMoveVelocity.magnitude * Time.deltaTime);
            if (_playerInput != Vector3.zero)
            {
                float angle = Vector3.SignedAngle(Vector3.forward, _playerMoveVelocity, Vector3.up) * Time.deltaTime * _playerRotationSpeed;
                transform.forward = Quaternion.Euler(0, angle, 0) * transform.forward;
                return;
            }
        }
    }
}