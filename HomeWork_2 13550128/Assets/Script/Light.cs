using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {

	public GameObject LightA;
	bool IsKill = false;
	public GameObject[] Prison = new GameObject[16];
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			StartCoroutine(OffLight());
	}

	IEnumerator OffLight(){
		LightA.SetActive(false);
		yield return new WaitForSeconds (0.5f);
		LightA.SetActive(true);
		yield return new WaitForSeconds (0.5f);
		LightA.SetActive(false);
		yield return new WaitForSeconds (0.5f);
		LightA.SetActive(true);
		yield return new WaitForSeconds (1f);
	}

	IEnumerator Hurt(){
		Prison[0].transform.eulerAngles = new Vector3(0,-5,0);
		yield return new WaitForSeconds (0.25f);
		Prison[0].transform.eulerAngles = new Vector3(0,-10,0);
		yield return new WaitForSeconds (0.25f);
		Prison[0].transform.eulerAngles = new Vector3(0,-15,0);
		yield return new WaitForSeconds (0.25f);
		Prison[0].transform.eulerAngles = new Vector3(0,-20,0);
		yield return new WaitForSeconds (0.25f);
		Prison[0].transform.eulerAngles = new Vector3(0,-25,0);
		yield return new WaitForSeconds (0.25f);
		Prison[0].transform.eulerAngles = new Vector3(0,-30,0);
		yield return new WaitForSeconds (2f);
		Kill();
	}

	void Kill(){
		for(int i = 0;i<16;i++){
			Prison[i].GetComponent<Rigidbody>().isKinematic=false;
		}
	}

	public void ClickK(){
		StartCoroutine(Hurt ());
	}

}
