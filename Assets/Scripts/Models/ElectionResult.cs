public class ElectionResult
{
  public string StateName;
  public string Result;

  public ElectionResult(string result, string stateName)
  {
    this.StateName = stateName;
    this.Result = result;
  }


}
