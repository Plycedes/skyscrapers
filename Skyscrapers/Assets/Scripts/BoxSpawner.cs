using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box_Prefab1;
    public GameObject box_Prefab2;
    public GameObject box_Prefab3;
    public GameObject box_Prefab4;
    public GameObject box_Prefab5;
    public GameObject box_Prefab6;    

    public void SpawnBox()
    {
        int id = Random.Range(0, 6);

        if(id == 0)
        {
            GameObject box_Obj1 = Instantiate(box_Prefab1);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj1.transform.position = temp;
        }

        else if (id == 1)
        {
            GameObject box_Obj2 = Instantiate(box_Prefab2);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj2.transform.position = temp;
        }

        else if (id == 2)
        {
            GameObject box_Obj3 = Instantiate(box_Prefab3);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj3.transform.position = temp;
        }

        else if (id == 3)
        {
            GameObject box_Obj4 = Instantiate(box_Prefab4);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj4.transform.position = temp;
        }

        else if (id == 4)
        {
            GameObject box_Obj5 = Instantiate(box_Prefab5);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj5.transform.position = temp;
        }

        else if (id == 5)
        {
            GameObject box_Obj6 = Instantiate(box_Prefab6);

            Vector3 temp = transform.position;
            temp.z = 0f;    //transform the box to 0 in z axis by using a temp var

            box_Obj6.transform.position = temp;
        }

    }
}
