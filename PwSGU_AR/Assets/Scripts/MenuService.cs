using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuService : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;
    private List<GameObject> cubes;
    private List<GameObject> spheres;
    private List<GameObject> cylinders;
    // Start is called before the first frame update
    void Start()
    {
        cubes = new List<GameObject>();
        spheres = new List<GameObject>();
        cylinders = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createCube()
    {
        GameObject newCube = Instantiate(cubePrefab, new Vector3(0,0,1), Quaternion.identity);
        newCube.SetActive(true);
        cubes.Add(newCube);
    }

    public void createSphere()
    {
        GameObject newSphere = Instantiate(spherePrefab, new Vector3(-0.5f, 0, 1), Quaternion.identity);
        newSphere.SetActive(true);
        spheres.Add(newSphere);
    }

    public void createCylinder()
    {
        GameObject newCylinder = Instantiate(cylinderPrefab, new Vector3(0.5f, 0, 1), Quaternion.identity);
        newCylinder.SetActive(true);
        cylinders.Add(newCylinder);
    }

    public void deleteAllCubes()
    {
        foreach (GameObject cube in cubes)
            Destroy(cube);
        cubes.Clear();
    }

    public void deleteAllSpheres()
    {
        foreach (GameObject sphere in spheres)
            Destroy(sphere);
        spheres.Clear();
    }

    public void deleteAllCylinders()
    {
        foreach (GameObject cylinder in cylinders)
            Destroy(cylinder);
        cylinders.Clear();
    }

    public void deleteAllShapes()
    {
        deleteAllCubes();
        deleteAllSpheres();
        deleteAllCylinders();
    }

    public void closeApp()
    {
        Application.Quit();
    }
}
