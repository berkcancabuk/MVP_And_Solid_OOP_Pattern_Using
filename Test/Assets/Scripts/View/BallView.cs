using System;
using UnityEngine;
namespace View
{
    public class BallView : MonoBehaviour, IBallView
    {
        private Vector3 _position;
        private IBallView _ballViewImplementation;
        public event Action Triggered = null;

        public void Disable()
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Surface"))
            {
                Triggered.Invoke();
            }
        }
    }
}