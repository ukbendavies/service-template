using System.Collections.Generic;
using System.Diagnostics;
using Template.Generated.Client.Api;
using Template.Generated.Client.Client;
using Template.Generated.Client.Model;

Configuration config = new Configuration();
config.BasePath = "http://localhost:8080/v1";
var apiInstance = new PetsApi(config);

try
{
    List<Pet> pets = apiInstance.ListPets();
    foreach(Pet pet in pets) {
        Console.WriteLine(pet.ToString());
    }
}
catch (ApiException  e)
{
    Debug.Print("Exception when calling PetsApi.ListPets: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}