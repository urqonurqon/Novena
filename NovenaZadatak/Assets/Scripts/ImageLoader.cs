using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using TMPro;

public class ImageLoader : MonoBehaviour
{
    public RawImage image;
    public TMP_Text description;

    int index = 0;

    string[] filesList = Directory.GetFiles(Path.Combine(Application.streamingAssetsPath, "Gallery"));
    List<string> imageList=new List<string>();

    List<string> descriptionList = new List<string>();


    private void Start()
    {
        for (int i = 0; i < filesList.Length; i++)
        {
            if (Regex.IsMatch(filesList[i], @"\.jpg$|\.png$")) //dodat u regex koje god nam trebaju extenzije za slike
            {
                imageList.Add(filesList[i]);
            }
            if (Regex.IsMatch(filesList[i], @"\.txt$"))
            {
                descriptionList.Add(filesList[i]);
            }
        }

        ChangeImageTexture(imageList, descriptionList, index);

    }

    public void Next()
    {
        index++;
        if (index > imageList.Count-1) index = 0;

        ChangeImageTexture(imageList, descriptionList, index);
    }
    public void Prev()
    {
        index--;
        if (index < 0) index = imageList.Count-1;

        ChangeImageTexture(imageList, descriptionList, index);
    }

    void ChangeImageTexture(List<string> imageList, List<string> descList, int i)
    {
        var rawdata = File.ReadAllBytes(imageList[i]);
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(rawdata);
        image.texture = tex;
        description.text = File.ReadAllText(descList[i]);
    }
}
