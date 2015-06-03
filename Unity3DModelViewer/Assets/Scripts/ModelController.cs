using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Transform))]
public class ModelController : MonoBehaviour {

	private Vector3 m_oriPosition;
	private Quaternion m_oriRotation;
	private Vector3 m_oriScale;

	// Use this for initialization
	void Start () {
		m_oriPosition = this.transform.position;
		m_oriRotation = this.transform.rotation;
		m_oriScale = this.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) {
			Debug.Log("pos:" + m_oriPosition);
		}
	}
}
