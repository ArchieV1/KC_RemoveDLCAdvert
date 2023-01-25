using UnityEngine;

namespace RemoveDLCAdvert
{
    public class RemoveDLCAdvert : MonoBehaviour
    {
        public void Preload(KCModHelper helper)
        {
            
        }

        public void Start()
        {
            Destroy(GameObject.Find("DLCButton"));
        }
    }
}