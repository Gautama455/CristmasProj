using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Interactive;

namespace Environment 
{
    public abstract class Spawner : MonoBehaviour
    {
        [Header("Возможные объекты для спавна")]
        [Tooltip("Список префабов возможных для спавна подарков")]
        [SerializeField] private List<Gift> _listOfPresents;
        public virtual Gift SpawnPresent(Gift present) { return _listOfPresents?.Count > 0 ? _listOfPresents[Random.Range(0, _listOfPresents.Count)] : null ; }
    }
}