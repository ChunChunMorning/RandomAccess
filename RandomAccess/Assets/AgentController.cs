using UnityEngine;

public class AgentController : MonoBehaviour
{
	NavMeshAgent m_NavMeshAgent;

	void Awake ()
	{
		m_NavMeshAgent = GetComponent<NavMeshAgent> ();

		var dst = GameObject.Find ("Destination");

		m_NavMeshAgent.destination = dst.transform.position;
	}
}
