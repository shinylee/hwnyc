using UnityEngine;
using System.Collections;

public class ny : MonoBehaviour {
	
	public GameObject Cube1;
	public GameObject Cube2;
	public GameObject Cube3;
	public GameObject Cube4;


	void Start () {
		StartCoroutine ( nyProcess() ); // call the coroutine; without this, nothing happens
	}

	
	IEnumerator nyProcess () {			

		int counter = 0;
		int positionZ = -10;
		float randomN= Random.Range (0, 5f);



		while (counter<15) {


			if( randomN < 2f){

				Instantiate( Cube1 , new Vector3(Random.Range(-6f, 12f), 0f, positionZ), Quaternion.identity);
				positionZ ++;
			}

			if(randomN < 3f){

				Instantiate( Cube2 , new Vector3( Random.Range(-6f, 12f) , 0f, positionZ ),Quaternion.identity );
				positionZ ++;

			}

			if(randomN < 4f){

				Instantiate( Cube3 , new Vector3(Random.Range(-6f, 12f), 0f,  positionZ ),Quaternion.identity);
				positionZ ++;

			}

			if(randomN < 5f){

				Instantiate( Cube4 , new Vector3(Random.Range(-6f, 12f), 0f,  positionZ), Quaternion.Euler(90,0,0));
				positionZ ++;
			}

		counter++;
		yield return new WaitForSeconds(0.1f);
		
		
	}

}

	void Update () {
		if ( Input.GetKey (KeyCode.R) ) {
			Application.LoadLevel(0);
		}
	}
}

