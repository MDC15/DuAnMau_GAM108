using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class StorageManager
{
    public static bool SaveToFile(string fileName, string json)
    {
        try
        {
            string directoryPath = Path.Combine(Application.persistentDataPath, "LocalDB");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
            return true;
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error Saving File {e.Message}");
            return false;
        }
    }

    public static string LoadFromFile(string fileName)
    {
        try
        {
            string filePath = Path.Combine(Application.persistentDataPath, "LocalDB", fileName);
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                Debug.LogError($"Error Loading File {fileName}");
                return null;
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error Loading File {e.Message}");
            return null;
        }
    }
}
