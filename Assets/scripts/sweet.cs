using UnityEngine;
using System.Collections;

public class sweet : MonoBehaviour {
	
	public Transform cake; 
	public Transform cookie; 
	public Transform donut; 


	int rangeFinder;
	float distFinder; 
	float nextPlantingTime = 0f;
	//float randomN; 

	// Use this for initialization
	void Start () {
		nextPlantingTime = Time.time + 2f;
		//randomN = Random.Range ( 1f, 5f);
		//distFinder = Random.Range (1f, 5f); // distance to next planting opportunity
	
	}
	
	// Update is called once per frame
	void Update () {

		/*
		if (Time.time > nextPlantingTime ) {
			//randomN > 0f && randomN < 2f 

			if (Random.Range (0f, 1f) > 0.8f ) {  
				Instantiate ( cake, transform.position, Quaternion.identity );
			} 

			else if (Random.Range (0f, 1f) > 0.5f ) { 
				Instantiate ( cookie, transform.position, Quaternion.identity );
			} 

			else if  (Random.Range (0f, 1f) > 0.1f ) { 
				Instantiate ( donut, transform.position, Quaternion.identity );
			} 

		nextPlantingTime += Random.Range( 5f, 10f); // set the next planting time
		}	
	*/

		int i = 0;
		while ( i<1 )  {
			

			if (Time.time > nextPlantingTime ) {
				
				rangeFinder = Random.Range (0, 30); // % chance of picking an ingredient
				
				if (rangeFinder > 20 && rangeFinder < 30 ) { 
					Instantiate ( cake, transform.position, Quaternion.identity );
				} 
				
				else if (rangeFinder > 10 && rangeFinder < 20 ) { 
					Instantiate ( cookie, transform.position, Quaternion.identity );
				} 
				
				else if (rangeFinder > 0 && rangeFinder < 10 ) { 
					Instantiate ( donut, transform.position, Quaternion.identity );
				} 

//				nextPlantingTime += distFinder; 
				nextPlantingTime += Random.Range( 1f, 3f);

			}

			i++;
			
		}
	}
}
