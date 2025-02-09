using UnityEngine;
using Unity.Netcode;

namespace TestProject.ManualTests
{
    public class NetworkManagerTestDisabler : MonoBehaviour
    {
        public static bool IsIntegrationTest;

        private void Awake()
        {
            if (IsIntegrationTest)
            {
                var networkManager = GetComponent<NetworkManager>();
                if (networkManager != null)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
