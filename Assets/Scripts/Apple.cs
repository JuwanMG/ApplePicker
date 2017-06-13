using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
    public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
<<<<<<< HEAD
<<<<<<< HEAD
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }

        
=======
        }
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
=======
        }
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
	}
}
