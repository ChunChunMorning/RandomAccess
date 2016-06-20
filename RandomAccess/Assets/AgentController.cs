using UnityEngine;

public class AgentController : MonoBehaviour
{
	NavMeshAgent m_NavMeshAgent;
	DestinationConroller m_DestinationConroller;

	void Awake ()
	{
		m_NavMeshAgent = GetComponent<NavMeshAgent> ();
		m_DestinationConroller = FindObjectOfType<DestinationConroller> ();

		var dst = GameObject.Find ("Destination");

		m_NavMeshAgent.destination = dst.transform.position;
	}

	void Start ()
	{
		m_DestinationConroller.AddPopulation ();
	}
}
