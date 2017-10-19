using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using UnityEngine;
using System.Net.Security;

public partial class TweetHandle : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ts = GameObject.FindGameObjectsWithTag("t");
        bs = GameObject.FindGameObjectsWithTag("s");
        foreach (GameObject tst in ts)
        {
            var link = tst.GetComponent<BottomText>();
            System.Random r = new System.Random();
            link.changeText(options[r.Next(0,9)]);
        }
        foreach (GameObject tst in bs)
        {
            var link = tst.GetComponent<BottomText>();
            System.Random r = new System.Random();
            link.changeText(names[r.Next(0, 9)]);
        }
        }
    }
    public GameObject[] ts;
    public GameObject[] bs;
    void Start()
    {
        ts = GameObject.FindGameObjectsWithTag("t");
        bs = GameObject.FindGameObjectsWithTag("s");
        foreach (GameObject tst in ts)
        {
            var link = tst.GetComponent<BottomText>();
            System.Random r = new System.Random();
            link.changeText(options[r.Next(0,options.Length)]);
        }
        foreach (GameObject tst in bs)
        {
            var link = tst.GetComponent<BottomText>();
            System.Random r = new System.Random();
            link.changeText(names[r.Next(0, 9)]);
        }
    }

    string[] names = new string[10] { "Matt", "Joanne", "Robert","Courtney","Dan","Grey","Alex","Jacob","Jared","Jack" };
    string[] options = new string[] { "Time flies like an arrow. Fruit flies like a banana.", "Show me a piano falling down a mineshaft and I'll show you A-flat minor.", "To write with a broken pencil is pointless.", "A bicycle can't stand on its own because it is two-tired.", "Those who get too big for their britches will be exposed in the end.", "When a clock is hungry it goes back four seconds.", "A chicken crossing the road is poultry in motion.", "If you don't pay your exorcist you get repossessed.", "What's the definition of a will? It's a dead giveaway.", "The man who fell into an uphotery machine is fully recovered.", "Every calendar's days are numbered.", "Bakers trade bread recipes on a knead to know basis.", "When the electricity went off during a storm at a school the students were de-lighted." };

}