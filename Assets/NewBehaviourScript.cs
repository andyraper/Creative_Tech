using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour
{
	public float buildingHeight = 50.0f;
	public float slidervalue = 1.0f;
	public float numberOfBuildings = 20.0f;
	public float buildingNumber = 20.0f;
	public float complexity = 10.0f;


		void  Start ()
		{

				
		}

		GameObject generateBuilding ()
		{
		GameObject cluster = new GameObject();

		float buildComplexity = Mathf.RoundToInt(Random.Range(2.0f,5.0f));

				for (int i = 0; i < (buildComplexity*complexity) ; i++) {
						GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
						//cube.transform.position = new Vector3 (0, 0, 0);
						cube.transform.localPosition = new Vector3 (Random.Range (-1.5f, 1.5f), Random.Range (0f, 1.0f), Random.Range (-1.5f, 1.5f));
						cube.transform.localScale = new Vector3 (Random.Range (0f, 4.0f), Random.Range (0f, buildingHeight), Random.Range (0.0f, 4.0f));
						cube.transform.parent = cluster.transform;

						//cluster.name.Equals ("building");
			//cluster.AddComponent<BoxCollider>();
				}
		return cluster;
		//cluster.AddComponent<BoxCollider> ();
		}

		void OnGUI()
	{
		buildingHeight = Mathf.RoundToInt( GUI.HorizontalSlider (new Rect (35, 15, 100, 30), buildingHeight, 0.0f, 50.0f));
		GUI.Box(new Rect(155, 15, 200, 30), "Building Height :" + buildingHeight*2 + "%");
		GUI.Label (new Rect (35, 25, 200, 30), "Building Height");

		buildingNumber = Mathf.RoundToInt(GUI.HorizontalSlider (new Rect (635, 15, 100, 30), buildingNumber, 0.0f, 20.0f));
		GUI.Box(new Rect(775, 15, 200, 30), "Number Of Buildings : " +  buildingNumber);
		GUI.Label (new Rect (635, 25, 200, 30), "Number Of Buildings");

		complexity = Mathf.RoundToInt(GUI.HorizontalSlider (new Rect (635, 55, 100, 30), complexity, 1.0f, 10.0f));
		GUI.Box(new Rect(775, 55, 200, 30), "Building Complexity : " +  complexity);
		GUI.Label (new Rect (635, 65, 200, 30), "Building Complexity");

		if (GUI.Button (new Rect (35, 55, 200, 30), "Build in sector 1")) 
		{
			for (int y = 0; y < buildingNumber; y++) {
				//generateBuilding();
				GameObject buildingCluster = generateBuilding();
				buildingCluster.transform.position = new Vector3 (Random.Range (-20.0f, 20.0f), 0, Random.Range (-20.0f, 20.0f));

			}

		}

		if (GUI.RepeatButton (new Rect (35, 95, 100, 30), "Clear")) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}


	}
	
}
