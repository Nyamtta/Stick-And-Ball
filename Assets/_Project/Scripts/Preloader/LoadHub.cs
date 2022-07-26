using UnityEngine;

namespace Scripts.Preloader
{
    public class LoadHub : MonoBehaviour
    {
        [SerializeField] private GameObject _loadHub;

        public void show() => _loadHub.SetActive(true);

        public void hide() => _loadHub.SetActive(false);
    }
}