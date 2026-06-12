using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ItemSelection.Models;

public record Student(string LastName, string FirstName, string Patronymic, ObservableCollection<string> Items);