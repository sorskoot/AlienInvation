using Metromino.Interfaces;

using RealityCollective.ServiceFramework.Definitions;
using RealityCollective.ServiceFramework.Interfaces;
using RealityCollective.ServiceFramework.Services;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine.Experimental.XR.Interaction;

namespace Metromino
{
    [System.Runtime.InteropServices.Guid("e39ca17b-1edb-41b7-82b2-b3eb4a6ad609")]
    public class GameStateService : BaseServiceWithConstructor, IGameStateService
    {
        private BoolReactiveProperty isPlaced = new BoolReactiveProperty(false);
        public BoolReactiveProperty IsPlaced => isPlaced;
        
        public GameStateService(string name, uint priority, GameStateServiceProfile profile)
            : base(name, priority)
        {
        }

        public void Place()
        {
            isPlaced.Value = true;
        }
    }
}
