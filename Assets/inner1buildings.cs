using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inner1buildings : MonoBehaviour
{
	void  Start ()
	{
		//float rndRangeMin_x = Random.Range (-40.0f, -20.0f);
		//float rndRangeMax_x = Random.Range (20.0f, 40.0f);

		//float rndRangeMin_z = Random.Range (-40.0f, -20.0f);
		//float rndRangeMax_z = Random.Range (20.0f, 40.0f);

			for (int x = 0; x < 100; x++) 
		{
				
				GameObject buildingCluster_inner1 = generateBuilding();
			buildingCluster_inner1.transform.position = new Vector3((Random.Range (-40.0f, 40.0f)), 0, (Random.Range (-40.0f, 40.0f)));
				//buildingCluster_inner1.name = "buildingCluster_inner1";
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
			cube.transform.localScale = new Vector3 (Random.Range (0f, 3.0f), Random.Range (0f, 35.0f), Random.Range (0.0f, 3.0f));
			//cube.AddComponent("BoxCollider");
			cube.transform.parent = cluster.transform;
		
		}
		return cluster;	
	}
}