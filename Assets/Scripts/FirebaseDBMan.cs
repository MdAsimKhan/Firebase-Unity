using Firebase.Database;
// line 3 for READ
using Firebase.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseDBMan : MonoBehaviour
{
    string userId;
    DatabaseReference reference;

    void Start()
    {
        userId = SystemInfo.deviceUniqueIdentifier;
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        /*CreateNewUser();*/
        /*ReadDatabase();*/
        RemoveUserWithUserID();
    }

    // CREATE/UPDATE
    /*public void CreateNewUser()
    {
        reference.Child("users")
            .Child(userId)
            .Child("name")
            .SetValueAsync("John Doe");

        reference.Child("users")
            .Child(userId)
            .Child("score")
            .SetValueAsync(100);
        Debug.Log("New User Created");
    }*/

    // READ
    public void ReadDatabase()
    {
        // only prints john doe
        reference.Child("users")
                 .Child(userId)
                 .Child("name")
                 .GetValueAsync().ContinueWithOnMainThread(task => {
                     if (task.IsFaulted)
                     {
                         Debug.Log(task.Exception.Message);
                     }
                     else if (task.IsCompleted)
                     {
                         DataSnapshot snapshot = task.Result;
                         Debug.Log("Name=" + snapshot.Value);
                     }
                 });
    }

    // DELETE
    public void RemoveUserWithUserID()
    {
        reference.Child("users")
            .Child(userId)
            .RemoveValueAsync();

        Debug.Log("User removed");
    }
}