using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save : MonoBehaviour
{
    public static void SaveFlower(Flower flower)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/plant.citrushack";
        FileStream stream = new FileStream(path, FileMode.Create);

        Flower data = new Flower(flower);

        formatter.Serialize(stream, data);
        stream.Close(); 
    }
    public static Flower LoadFlower()
    {
        string path = Application.persistentDataPath + "/plant.citrushack";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Flower data = formatter.Deserialize(stream) as Flower;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
