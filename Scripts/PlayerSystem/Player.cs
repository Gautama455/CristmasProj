using Interactive;
using UnityEngine;

namespace Gameplay
{
    public class Player : MonoBehaviour
    {
        private float _coinCount;

        private void Awake() { _coinCount = 0f; }

        public void OnGiftCorrectlyPlaced(Gift gift) { _coinCount += gift.Config.CoinCountCorrect; }

        public void OnGiftWronglyPlaced(Gift gift) { _coinCount = _coinCount > gift.Config.CoinCountWrong ? _coinCount - gift.Config.CoinCountWrong: 0f; }
    }
}