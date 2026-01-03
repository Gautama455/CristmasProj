using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Gameplay;

namespace Configs
{
    [CreateAssetMenu(fileName = "CollectorConfig", menuName = "Configs/CollectorConfig")]
    public class CollectorConfig : ScriptableObject
    {
        [Header("Коллайдер")]
        [Tooltip("Ссылка на зону, куда будут попадать подарки для дальнейшего анализа")]
        [SerializeField] private Collider _collectorCollider;
        public Collider CollectorCollider => _collectorCollider;

        [Header("Префабы")]
        [Tooltip("Ссылка на префабы разрешенных объектов")]
        [SerializeField] private List<GameObject> _allowsPrefabs;
        
        public List<System.Type> AllowsTypes => _allowsPrefabs?.Where(p => p != null).
            Select(t => t.GetComponent<Interactive.Gift>()?.GetType()).
            Where(t => t != null).
            ToList();

        [Header("Игрок")]
        [Tooltip("Ссылка на объект игрока")]
        [SerializeField] private Player _player;
        public Player Player => _player;
    }
}