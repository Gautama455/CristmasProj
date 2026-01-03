using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Configs", menuName = "Configs/GiftConfig")]
    public class GiftConfig : ScriptableObject
    {
        [Header("Начисление/вычитание коинов")]
        [Tooltip("Вознаграждение за правильное распределение")]
        [SerializeField] private float _coinCountCorrect;
        [Tooltip("Штраф за неправильное распределение ")]
        [SerializeField] private float _coinCountWrong;

        [Header("Rigidbody параметры")]
        [Tooltip("Масса")]
        [SerializeField] private float _mass;
        [Tooltip("Коэф. трения")]
        [SerializeField] private float _drag;

        [Tooltip("Использование гравитации")]
        [SerializeField] private bool _useGravity;
        [SerializeField] private float _forceMultuplier;

        public float CoinCountCorrect => _coinCountCorrect;
        public float CoinCountWrong => _coinCountWrong;

        public float Mass => _mass;
        public float Drag => _drag;
        public bool UseGravity => _useGravity;
        public float ForceMultiplier => _forceMultuplier;
    }
}