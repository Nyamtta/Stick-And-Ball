using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.Preloader
{
    public class Preloader : MonoBehaviour
    {
        private void Start()
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
    }

}