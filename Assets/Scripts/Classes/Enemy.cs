using UnityEngine;
using System.Collections;
using System.Collections.Generic;




public class Enemy : Character 
{
	//square root of 2
	private const float SQRT2 = 1.414213562373095f;

	//enemy moving system
	bool moving = false;
	private bool wantToMove = true;
	//Vector3 destination = new Vector3(13.18f, 3.310567f, -17.96225f);
	Vector3 destination;


	//Vector3 destination2 = new Vector3(-5,1-5);
	//Vector3 destination3 = new Vector3(-5,1,5);
	//Vector3 destination4 = new Vector3(-5,1,5);
	//private Vector3 currWaypoint;
	//private Vector3 currMovement;


	//private Stack<Vector3> moves = new Stack<Vector3>();

	//enemy navigation
	NavMeshAgent navAgent;

	//enemy belief system
	Dictionary<string, PositionBelief> positionBeliefSet; //dictionary with all position beliefs. key is the itemID, value is the positionBelief
	Dictionary<string, StateBelief> stateBeliefSet; //dictionary with all states beliefs. key is the itemID, value is the stateBelief
	Object beliefTarget; //Target to seek in belief set for position or state, depending on the following booleans
	bool checkBeliefForPosition = false;
	Vector3 beliefTargetPosition;
	bool checkBeliefForState = false;
	Object beliefTargetState; //mudar para o objeto de estado a ser utilizado no futuro

	Vector3[] routine = {new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f), 
		new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f), 
		new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f), 
		new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f), 
		new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f), 
		new Vector3(1.81f, -3.31667f, -6.76f), new Vector3(13.18f, 3.310567f, -17.96225f), new Vector3(-21.21f, 0f, 16.62f), new Vector3(-7.13f, -2.96f, -7.2f)};

	EmotionManager emotionManager;

	//Enemy inventory
	Inventory inventory;

	//action queue for the enemy
	List<ActionChain> actionlist;





	// Use this for initialization
	void Start() {
		base.Start();
		//Teste();
		//moves = astar(destination1);

		positionBeliefSet = new Dictionary<string, PositionBelief>();
		stateBeliefSet = new Dictionary<string, StateBelief>();


		//Item radio = new Item("1", "radio");
		//PositionBelief radiopos = new PositionBelief(radio.itemId, new Vector3(-9.51f,2.64f,-6.112f));

		//positionBeliefSet.Add(radio.itemId, radiopos);


		//beginMovement = true;
		navAgent = GetComponent<NavMeshAgent>();

		navAgent.SetDestination(routine[0]);

		InGameTime.getInstance(); //para nao precisar fazer isso, criar uma prefab invisivel no mapa para sempre carregar o singleton de tempo nela
		
		emotionManager = new EmotionManager();

		inventory = new Inventory();

		//TestInventory();

		//TestMaxHeap();
	
	}

	void obeyRoutine()
	{
		if(!moving)
		{
			char[] split = {':'};
			string number = InGameTime.getInstance().getTime().Split(split)[0];
			//
			destination = routine[int.Parse(number)];
			Debug.Log(destination);

			if(destination != transform.position)
			{
				Debug.Log(" a");
				navAgent.SetDestination(destination);
				moving = true;
			}
		}
	}

	void obeyEmotions()
	{
		if(emotionManager.howHungry() > 20)
		{
			destination = routine[3];
			Debug.Log("com fome");
		}
			
		if(emotionManager.howTired() > 20)
		{
			destination = routine[2];
			Debug.Log("cansado");
		}

		if(!moving)
			navAgent.SetDestination(destination);
			
	}

	
	// Update is called once per frame
	void Update () 
	{
		/*if(beginMovement)
		{
			beginMovement = false;
			//currWaypoint = transform.position;
			//navAgent.SetDestination(destination1);
			navAgent.SetDestination(positionBeliefSet["1"].position);
		}*/


		//obeyRoutine();
		//obeyEmotions(); temporariamente removido para o teste de itens
		if(moving != false)
			if(destination == transform.position)
			{
				Debug.Log("moving = false");
				moving = false;
			}

		//move();

		emotionManager.updateEmotion();
	}

	//Test method to check if minheap works
	void TestMinHeap()
	{
		MinHeap<int> heap = new MinHeap<int>();
		heap.insert(0);
		heap.insert(2);
		heap.insert(3);
		heap.insert(4);
		heap.insert(5);
		heap.insert(-1);

		heap.print();
		Debug.Log(";llol");

		for(int i = 0; i < 6; i++)
		{
			heap.pop();

			heap.print();
			Debug.Log(";llol");
		}
	}

	//Test method to check if maxheap works
	void TestMaxHeap()
	{
		MaxHeap<int> heap = new MaxHeap<int>();
		heap.insert(0);
		heap.insert(2);
		heap.insert(3);
		heap.insert(4);
		heap.insert(5);
		heap.insert(-1);

		heap.print();
		Debug.Log(";llol");

		for(int i = 0; i < 6; i++)
		{
			heap.pop();

			heap.print();
			Debug.Log(";llol");
		}
	}

	//TEST METHOD TO PICKUP AN ITEM BASED ON BELIEF SYSTEM
	//ta funcionando
	void TestInventory()
	{
		Item dummyItem = new Item("1", "dummy");
		positionBeliefSet.Add(dummyItem.itemId, new PositionBelief(dummyItem.itemId, new Vector3(17.87f, 3.509f, -9.75f)));

		PositionBelief belief = positionBeliefSet[dummyItem.itemId];
		navAgent.SetDestination(belief.position);
	}





	float distance(Vector3 a, Vector3 b)
	{
		return Mathf.Sqrt( Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2) + Mathf.Pow(a.z - b.z, 2));
	}

	bool v3Comparison(Vector3 a, Vector3 b)
	{
		return Vector3.SqrMagnitude(a - b) < 1f;
	}
}


//COMENTADO POIS EH O PATHFINDING ANTIGO
/*void move()
	{
		if(currWaypoint == transform.position)
		{
			if(moves.Count != 0)
			{
				currWaypoint = moves.Pop();
				currMovement = currWaypoint - transform.position;
			}
			else
			{
				moves = astar(destination4);
			}

		}


		//transform.Translate(currMovement * Time.deltaTime * velocity) ;
		transform.position = Vector3.MoveTowards(transform.position, currWaypoint,Time.deltaTime * velocity);
	}



	Stack<Vector3> astar(Vector3 destination)
	{
		MinHeap<AStarTuple> open = new MinHeap<AStarTuple>();
		HashSet<AStarTuple> closed = new HashSet<AStarTuple>();

		open.insert(new AStarTuple(0, this.distanceTo(destination), gameObject.transform.position));
		int count = 0;

		while(true)
		//while(count < 50)
		{
			count++;
			//open.print();

			AStarTuple closest = open.pop();
			Debug.Log("CLOSEST ESCOLHIDO: " + closest);

			//if we hit the end, we must stop and backtrack every action we took.
			if(v3Comparison(closest.position, destination)) 
			{
				closest.position = destination;
				Stack<Vector3> moves = new Stack<Vector3>();
				while(closest != null)
				{
					moves.Push(closest.position);
					closest = closest.lastStep;
				}

				//return;
				return moves;
			}


			closed.Add(closest);
//			AStarTuple lol = new AStarTuple(closest.costDistance, closest.heurDistance, closest.position, closest.lastStep);
//			if(closed.Contains(lol))
//			{
//				Debug.Log("era pra dar certo");
//			}

			//adds 8 possible movements: forward, backwards, left, right and diagonals
			Vector3 pos = closest.position + Vector3.forward; //* velocity;
			AStarTuple aux = new AStarTuple(closest.costDistance+1, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			pos = closest.position + Vector3.back;// * velocity;
			aux = new AStarTuple(closest.costDistance+1, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}
			pos = closest.position + Vector3.left;// * velocity;
			aux = new AStarTuple(closest.costDistance+1, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			pos = closest.position + Vector3.right;// * velocity;
			aux = new AStarTuple(closest.costDistance+1, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			//DIAGONALS
			//0.707106781186548 = 1/sqrt(2)

			//northwest
			pos = closest.position + Vector3.forward + Vector3.left;// * velocity;
			aux = new AStarTuple(closest.costDistance+SQRT2, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			//northeast
			pos = closest.position + Vector3.forward + Vector3.right;// * velocity;
			aux = new AStarTuple(closest.costDistance+SQRT2, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			//southwest
			pos = closest.position + Vector3.back + Vector3.left;// * velocity;
			aux = new AStarTuple(closest.costDistance+SQRT2, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);	
			}
			else
			{
				Debug.Log("deu certo");	
			}

			//southeast
			pos = closest.position + Vector3.back + Vector3.right;// * velocity;
			aux = new AStarTuple(closest.costDistance+SQRT2, distance(pos, destination), pos, closest);
			if(!closed.Contains(aux))
			{
				open.insert(aux);
			}
			else
			{
				Debug.Log("deu certo");	
			}




			Debug.Log("Closed tem " + closed.Count + "elementos!");


		}
		//return null;

	}*/