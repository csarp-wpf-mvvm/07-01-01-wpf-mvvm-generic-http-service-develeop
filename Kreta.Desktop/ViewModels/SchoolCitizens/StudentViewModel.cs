using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.Service;
using Kreta.Desktop.ViewModels.Base;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {        
        private readonly IStudentService _studentService;

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new ObservableCollection<string>(new EducationLevels().AllEducationLevels);

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        [ObservableProperty]
        private Student _selectedStudent;

        private string _selectedEducationLevel = string.Empty;
        public string SelectedEducationLevel
        {
            get => _selectedEducationLevel;
            set
            {
                SetProperty(ref _selectedEducationLevel, value);
                SelectedStudent.EducationLevel = _selectedEducationLevel;
            }
        }        

        public StudentViewModel()
        {
            _studentService = new StudentService();
            SelectedStudent = new Student();
            SelectedEducationLevel = _educationLevels[0];
        }

        public StudentViewModel(IStudentService? studentService)
        {
            _studentService = studentService ?? throw new ArgumentNullException(nameof(studentService));
            SelectedStudent = new Student();
            SelectedEducationLevel = _educationLevels[0];
        }

        public override async Task InitializeAsync()
        {
            List<StudentDto> studentsDto = await _studentService.GetAllAsync<StudentDto>();
            List<Student> students= studentsDto.Select(s => s.ToStudent()).ToList();
            Students = new ObservableCollection<Student>(students);
        }
    }
}
