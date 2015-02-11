using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour
{
	public float buildingHeight = 50.0f;
	public float slidervalue = 1.0f;
	public float numberOfBuildings = 20.0f;

		void  Start ()
		{

				
				}
				
		
		

		GameObject generateBuilding ()
		{
		GameObject cluster = new GameObject();

				for (int i = 0; i < 3; i++) {
						GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
						//cube.transform.position = new Vector3 (0, 0, 0);
						cube.transform.localPosition = new Vector3 (Random.Range (-0.5f, 0.5f), Random.Range (0f, 1.0f), Random.Range (-0.5f, 0.5f));
						cube.transform.localScale = new Vector3 (Random.Range (0f, 3.0f), Random.Range (0f, buildingHeight), Random.Range (0.0f, 3.0f));

			cube.transform.parent = cluster.transform;
				}
		return cluster;

		}

		void OnGUI()
	{
		buildingHeight = GUI.HorizontalSlider (new Rect (35, 15, 100, 30), buildingHeight, 0.0f, 50.0f);
		GUI.Box(new Rect(155, 15, 200, 30), "Building Height :" + buildingHeight*2 + "%");
		GUI.Label (new Rect (35, 25, 200, 30), "Building Height");


		numberOfBuildings = Mathf.RoundToInt(GUI.HorizontalSlider (new Rect (635, 15, 100, 30), numberOfBuildings, 0.0f, 20.0f));
		GUI.Box(new Rect(775, 15, 200, 30), "Number Of Buildings" + numberOfBuildings);
		GUI.Label (new Rect (635, 25, 200, 30), "Number Of Buildings");

	

		if (GUI.Button (new Rect (35, 55, 200, 30), "Build in sector 1")) 
		{
			for (int y = 0; y < numberOfBuildings; y++) {
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
