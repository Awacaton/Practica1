using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {


        public Player Sphere;

        void OnMouseDown()
        {
            
            Sphere.life--;
        }

       
        // Use this for initialization
        void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}
}
