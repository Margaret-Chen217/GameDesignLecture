using UnityEngine;

public class Script_Exp0602 : MonoBehaviour
{

	private GameObject selectedObject;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.LogFormat("Raycast: {0} 3D坐标:{1}", hit.collider.name, hit.point);
				selectedObject = hit.collider.gameObject;
				selectedObject.GetComponent<Outline>().enabled = true;
            }

            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (var h in hits)
            {
                Debug.LogFormat("RaycastAll: {0} 3D坐标:{1}", hit.collider.name, hit.point);
            }
        }
    }
	// private RaycastHit CastRay(){
	// 	Vector3 ScreenFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
	// 	Vector3 ScreenNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);

	// 	Vector3 far = Camera.main.ScreenToWorldPoint(ScreenFar);
	// 	Vector3 near = Camera.main.ScreenToWorldPoint(ScreenNear);

	// 	RaycastHit hit;
	// 	Physics.Raycast(near, far - near, out hit);

	// 	return hit;
	// }
}
