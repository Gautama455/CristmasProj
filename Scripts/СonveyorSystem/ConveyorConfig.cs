using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Configs", menuName = "Configs/ConveyorConfig")]
    public class ConveyorConfig : ScriptableObject
    {
        [Header("Movement")]
        [Tooltip("Направление движения")]
        [SerializeField] private Vector3 _direction = Vector3.forward;
        [Tooltip("Скорость движения по конвееру")]
        [SerializeField] private float _speed = 5f;

        [Header("Physics")]
        [SerializeField] private float _forceMultuplier = 1f;
        [SerializeField] private LayerMask _movableLayers = 1;

        public Vector3 Direction => _direction;
        public float Speed => _speed;
        public float ForceMultiplier => _forceMultuplier;
        public LayerMask MovableLayers => _movableLayers;
    }
}