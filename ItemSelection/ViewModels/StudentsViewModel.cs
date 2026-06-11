using System.Collections.ObjectModel;
using ItemSelection.Models;

namespace ItemSelection.ViewModels;

public class StudentsViewModel : ViewModelBase
{
    
    public  ObservableCollection<Student> Students{ get; } = new(App.Students);

     public StudentsViewModel()
     {
         App.Students.Add(new Student("Иванов", "Иван", "Иванович", ["Математика", "Физика", "Информатика"]));
         App.Students.Add(new Student("Петров", "Петр", "Петрович", ["История", "Философия"]));
         App.Students.Add(new Student("Сидорова", "Анна", "Сергеевна", ["Химия", "Биология", "Английский"]));
         Students.Add(new Student("Иванов", "Иван", "Иванович", ["Математика", "Физика", "Информатика"]));
         Students.Add(new Student("Петров", "Петр", "Петрович", ["История", "Философия"]));
         Students.Add(new Student("Сидорова", "Анна", "Сергеевна", ["Химия", "Биология", "Английский"]));
     }
}