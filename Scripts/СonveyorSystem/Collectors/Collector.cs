using UnityEngine;
using Interactive;
using Configs;

namespace Environment
{
    public abstract class Collector : MonoBehaviour
    {
        [SerializeField] protected CollectorConfig _config;

        protected void OnCollisionEnter(Collision other)
        {
            var gift = other.gameObject.GetComponent<Gift>();
            if (CanCollect(gift)) CollectAllowed(gift);
            else RejectNotAllowed(gift);
        }

        public virtual void CollectAllowed(Gift gift) { _config.Player.OnGiftCorrectlyPlaced(gift); }

        public virtual void RejectNotAllowed(Gift gift) { _config.Player.OnGiftWronglyPlaced(gift); }
        
        protected bool CanCollect(Gift gift) =>
            gift != null && _config.AllowsTypes.Contains(gift.GetType());
    }
}