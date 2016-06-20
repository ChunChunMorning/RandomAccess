using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	[SerializeField] GameObject m_Students;

	void Awake ()
	{
		const int size = 6;

		for (int i = 0; i < size; ++i)
		{
			var pos = transform.position;

			pos.x += 4.5f * Mathf.Cos (i / (float)size * 2.0f * Mathf.PI);
			pos.z += 4.5f * Mathf.Sin (i / (float)size * 2.0f * Mathf.PI);

			Instantiate (m_Students, pos, Quaternion.identity);
		}
	}
}
