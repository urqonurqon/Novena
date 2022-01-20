using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class JSONReader : MonoBehaviour
{
    public Text textBox;

    string JSONtextPath = Path.Combine(Application.streamingAssetsPath, "Text\\JSONtext.json");
    
    [Serializable]
    public class JSONtext
    {
        public string jsontext { get; set; }
    }

    private void Start()
    {
        JSONtext text = JsonConvert.DeserializeObject<JSONtext>(File.ReadAllText(JSONtextPath));
        
        textBox.text = text.jsontext;
    }

}
