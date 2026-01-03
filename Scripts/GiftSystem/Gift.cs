using UnityEngine;
using Configs;

namespace Interactive
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Gift : MonoBehaviour, IConveyorMovable
    {
        [SerializeField] private GiftConfig _config;
        [SerializeField] private Rigidbody _rb;
        public GiftConfig Config => _config;

        private void Awake() { ApplyConfig(); _rb = GetComponent<Rigidbody>(); }

        private void ApplyConfig()
        {
            _rb.mass = _config.Mass;
            _rb.linearDamping = _config.Drag;
            _rb.useGravity = _config.UseGravity;
        }

        public void ApplyConveyorForse(Vector3 direction, float speed) =>
            _rb.AddForce(direction * speed * _config.ForceMultiplier, ForceMode.Acceleration);
    }

    public interface IConveyorMovable
    {
        public void ApplyConveyorForse(Vector3 direction, float speed);
    }
}