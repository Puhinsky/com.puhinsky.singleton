using UnityEngine;

namespace Puhinsky.Singleton
{
    public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = FindObjectOfType<T>();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
