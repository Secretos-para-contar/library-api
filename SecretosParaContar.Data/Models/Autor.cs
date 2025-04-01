using System.Reflection.Metadata.Ecma335;
using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Data.Models;

public class Autor : BaseEntity<int>
{

    public string Name { get; set; } = string.Empty;

    public int YearOfBirth { get; set; }
}