using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Template.Generated.Server.Attributes;
using Template.Generated.Server.Models;
using Template.Generated.Server.Controllers;

namespace Template.Presentation
{
    public class ApiController : PetsApiController
    {
        public override IActionResult CreatePets()
        {
            throw new NotImplementedException();
        }

        public override IActionResult ListPets(int? limit)
        {
            string exampleJson = null;
            exampleJson = "[{\n  \"name\" : \"name\",\n  \"id\" : 0,\n  \"tag\" : \"tag\"\n}]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);

            return new ObjectResult(example);
        }

        public override IActionResult ShowPetById(string petId)
        {
            string exampleJson = null;
            exampleJson = "{\n  \"name\" : \"name\",\n  \"id\" : 0,\n  \"tag\" : \"tag\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Pet>(exampleJson)
            : default(Pet);

            return new ObjectResult(example);
        }
    }
}