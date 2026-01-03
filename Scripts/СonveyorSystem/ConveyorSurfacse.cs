using UnityEngine;
using Configs;

namespace Environment
{
    public class ConveyorSurfacse : MonoBehaviour
    {
        [SerializeField] private ConveyorConfig _config;

        public ConveyorConfig Config => _config;

        private void Awake() { if(_config == null) _config = Resources.Load<ConveyorConfig>("DefaultConveyorConfig"); }

        public Vector3 GetDirection() => _config.Direction.normalized;
        public float GetSpeed() => _config.Speed;
        public float GetForceMultiplier() => _config.ForceMultiplier;
        public LayerMask GetMovableLayers() => _config.MovableLayers;
    }

    public interface IConveyorSurface
    {
        public Vector3 GetDirection();
        public float GetSpeed();
    }
}