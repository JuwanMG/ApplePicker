using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
<<<<<<< HEAD
<<<<<<< HEAD
    public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
        basketList = new List<GameObject>();
        for (int i= 0; i< numBaskets; i++)
=======

	// Use this for initialization
	void Start () {
	for (int i= 0; i< numBaskets; i++)
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
=======

	// Use this for initialization
	void Start () {
	for (int i= 0; i< numBaskets; i++)
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
<<<<<<< HEAD
<<<<<<< HEAD
            basketList.Add(tBasketGO);
=======
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
=======
>>>>>>> ab60857902fa47c99183570d545a69ac29c963c7
        }
	}
	
	// Update is called once per frame
	public void AppleDestroyed () {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }

        int basketIndex = basketList.Count - 1;
        GameObject tbasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tbasketGO);

        if (basketList.Count == 0)
        {
            Application.LoadLevel("ApplePicker");
        }
    }
}
