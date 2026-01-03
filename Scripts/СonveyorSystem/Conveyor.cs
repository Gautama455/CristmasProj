using Configs;
using Interactive;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment
{
    public class Conveyor : MonoBehaviour
    {
        private ConveyorConfig _config;
        private IConveyorSurface _surfase;

        void Awake()
        {
            _surfase = GetComponent<IConveyorSurface>();
            _config = (_surfase as ConveyorSurfacse)?.Config;
        }

        private void OnCollisionStay(Collision other)
        {
            if (other.gameObject.TryGetComponent(out IConveyorMovable movable))
                movable.ApplyConveyorForse(_surfase.GetDirection(), _surfase.GetSpeed());
        }
    }
}