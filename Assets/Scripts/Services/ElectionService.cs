using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ElectionService
{

  public static List<ElectionResult> Results;

  static ElectionService()
  {
    Results = new List<ElectionResult>();
    Results.Add(new ElectionResult("Trump", "Alabama"));
    Results.Add(new ElectionResult("Trump", "Alaska"));
    Results.Add(new ElectionResult("Trump", "Arizona"));
    Results.Add(new ElectionResult("Trump", "Arkansas"));
    Results.Add(new ElectionResult("Hillary", "California"));
    Results.Add(new ElectionResult("Hillary", "Colorado"));
    Results.Add(new ElectionResult("Hillary", "Connecticut"));
    Results.Add(new ElectionResult("Hillary", "Delaware"));
    Results.Add(new ElectionResult("Hillary", "District Of Columbia"));
    Results.Add(new ElectionResult("Trump", "Florida"));
    Results.Add(new ElectionResult("Trump", "Georgia"));
    Results.Add(new ElectionResult("Hillary", "Hawaii"));
    Results.Add(new ElectionResult("Trump", "Iowa"));
    Results.Add(new ElectionResult("Trump", "Idaho"));
    Results.Add(new ElectionResult("Hillary", "Illinois"));
    Results.Add(new ElectionResult("Trump", "Indiana"));
    Results.Add(new ElectionResult("Trump", "Kansas"));
    Results.Add(new ElectionResult("Trump", "Kentucky"));
    Results.Add(new ElectionResult("Trump", "Louisiana"));
    Results.Add(new ElectionResult("Hillary", "Maine"));
    Results.Add(new ElectionResult("Hillary", "Maryland"));
    Results.Add(new ElectionResult("Hillary", "Massachusetts"));
    Results.Add(new ElectionResult("Trump", "Michigan"));
    Results.Add(new ElectionResult("Hillary", "Minnesota"));
    Results.Add(new ElectionResult("Trump", "Mississippi"));
    Results.Add(new ElectionResult("Trump", "Missouri"));
    Results.Add(new ElectionResult("Trump", "Montana"));
    Results.Add(new ElectionResult("Trump", "Nebraska"));
    Results.Add(new ElectionResult("Hillary", "Nevada"));
    Results.Add(new ElectionResult("Hillary", "New Hampshire"));
    Results.Add(new ElectionResult("Hillary", "New Jersey"));
    Results.Add(new ElectionResult("Hillary", "New Mexico"));
    Results.Add(new ElectionResult("Hillary", "New York"));
    Results.Add(new ElectionResult("Trump", "North Carolina"));
    Results.Add(new ElectionResult("Trump", "North Dakota"));
    Results.Add(new ElectionResult("Trump", "Ohio"));
    Results.Add(new ElectionResult("Trump", "Oklahoma"));
    Results.Add(new ElectionResult("Trump", "Oregon"));
    Results.Add(new ElectionResult("Trump", "Pennsylvania"));
    Results.Add(new ElectionResult("Hillary", "Rhode Island"));
    Results.Add(new ElectionResult("Trump", "South Carolina"));
    Results.Add(new ElectionResult("Trump", "South Dakota"));
    Results.Add(new ElectionResult("Trump", "Tennessee"));
    Results.Add(new ElectionResult("Trump", "Texas"));
    Results.Add(new ElectionResult("Trump", "Utah"));
    Results.Add(new ElectionResult("Hillary", "Vermont"));
    Results.Add(new ElectionResult("Hillary", "Virginia"));
    Results.Add(new ElectionResult("Hillary", "Washington"));
    Results.Add(new ElectionResult("Trump", "West Virginia"));
    Results.Add(new ElectionResult("Trump", "Wisconsin"));
    Results.Add(new ElectionResult("Trump", "Wyoming"));
  }

}
