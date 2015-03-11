using UnityEngine;
using System.Collections;

public class innerbuildings2 : MonoBehaviour {

	void  Start ()
	{
		for (int x = 0; x < 1000; x++) {
			
			GameObject buildingCluster_inner1 = generateBuilding();
			buildingCluster_inner1.transform.position = new Vector3 (Random.Range (-100.0f, 100.0f), 0, Random.Range (-100.0f, 100.0f));
			buildingCluster_inner1.name = "buildingCluster_inner1";
		}
	}
	
	GameObject generateBuilding ()
	{
		GameObject cluster = new GameObject();
		//Bounds bounds = new Bounds (Vector3.zero, new Vector3(3,20,3));
		
		for (int i = 0; i < 3; i++) {
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			//cube.transform.position = new Vector3 (0, 0, 0);
			cube.transform.localPosition = new Vector3 (Random.Range (-0.5f, 0.5f), Random.Range (0f, 1.0f), Random.Range (-0.5f, 0.5f));
			cube.transform.localScale = new Vector3 (Random.Range (0f, 3.0f), Random.Range (0f, 20.0f), Random.Range (0.0f, 3.0f));
			cube.AddComponent<BoxCollider>();
			cube.transform.parent = cluster.transform;
			
		}
		return cluster;	
	}
}
