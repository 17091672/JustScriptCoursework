using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BacteriaPreFab : MonoBehaviour
{

    public Transform prefab;
    public KeyCode startClone = KeyCode.Space;//when space is clicked it clones the prefab, instantiation of a class
                                              //to do: use time as a factor not a key press
    List<Transform> objects;
    string savePath;
    public KeyCode saveKey = KeyCode.S;
    public KeyCode loadKey = KeyCode.L;

    void Update()
    {
        if (Input.GetKeyDown(startClone))
        {
            splitBacteria();
        }
        //lse if (Input.GetKey())
        //{
        //  BeginNewGame();
        //}
        else if (Input.GetKeyDown(saveKey))
        {
            Save();//saves progress for a perti dish
        }
        // else if (Input.GetKeyDown(loadKey))
        // {
        //   Load();//allows you to open a previous project
        //}
    }
    void splitBacteria()//clones and radomly places spheres
    {
        Transform t = Instantiate(prefab);
        t.localPosition = Random.insideUnitSphere * 5f;
        t.localRotation = Random.rotation;
        objects.Add(t);
    }
    void Awake()
    {
        objects = new List<Transform>();
        savePath = Path.Combine(Application.persistentDataPath, "saveFile");
    }
    void Save()
        {
            using (
                var writer = new BinaryWriter(File.Open(savePath, FileMode.Create))
            )
            {
                writer.Write(objects.Count);
                for (int i = 0; i < objects.Count; i++)
                {
                    Transform t = objects[i];
                    writer.Write(t.localPosition.x);
                    writer.Write(t.localPosition.y);
                    writer.Write(t.localPosition.z);
                }
            }
        }
    //void Load()//opens file
        //{
            //BeginNewGame();
            //using (
            //    var reader = new BinaryReader(File.Open(savePath, FileMode.Open))
          //      ) { }
        //int count = reader.ReadInt32();
        //for (int i = 0; i < count; i++)//how may bacteria produced
        //{
                //Vector3 p;
               // p.x = reader.ReadSingle();
             //   p.y = reader.ReadSingle();
           //     p.z = reader.ReadSingle();
         //}
          //for (int i = 0; i < count; i++)//vector to set the position of instanciated sphere (bacteria)
         //{
                //Vector3 p;
              //  p.x = reader.ReadSingle();
            //    p.y = reader.ReadSingle();
          //      p.z = reader.ReadSingle();
               // Transform t = Instantiate(prefab);
             //   t.localPosition = p;
           //     objects.Add(t);
         //}
        //}
    //void BeginNewGame()//when i want to clear the petri dish
      //  {
        //  for (int i = 0; i < objects.Count; i++)
          //  {
            //    Destroy(objects[i].gameObject);
            //}
            //objects.Clear();
        //}
    }
