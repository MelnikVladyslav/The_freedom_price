using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class MoveScript : MonoBehaviour
    {
        public Camera mainCamera;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y + 0.5f);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x - 0.5f, mainCamera.transform.position.y);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y - 0.5f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x + 0.5f, mainCamera.transform.position.y);
            }
        }
    }
}