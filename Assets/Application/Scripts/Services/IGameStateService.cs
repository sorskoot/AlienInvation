
using RealityCollective.ServiceFramework.Interfaces;
using UniRx;

namespace Metromino.Interfaces
{
    public interface IGameStateService : IService
    {
        public BoolReactiveProperty IsPlaced { get; }

        public void Place();
    }
}