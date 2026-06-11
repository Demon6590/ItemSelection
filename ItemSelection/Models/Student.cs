using System.Collections.Generic;

namespace ItemSelection.Models;

public record Student(string LastName, string FirstName, string Patronymic, List<string> Items);