
using RealityCollective.ServiceFramework.Definitions;
using RealityCollective.ServiceFramework.Interfaces;
using UnityEngine;

namespace Metromino
{
    [CreateAssetMenu(menuName = "GameStateServiceProfile", fileName = "GameStateServiceProfile", order = (int)CreateProfileMenuItemIndices.ServiceConfig)]
    public class GameStateServiceProfile : BaseServiceProfile<IServiceDataProvider>
    { }
}
