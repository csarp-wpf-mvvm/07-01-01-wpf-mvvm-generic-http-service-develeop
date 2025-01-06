using Kreta.Desktop.ViewModels.ControlPanel;
using Kreta.Desktop.ViewModels.SchoolCitizens;
using Kreta.Desktop.ViewModels.SchoolClasses;
using Kreta.Desktop.ViewModels.SchoolGrades;
using Kreta.Desktop.ViewModels.SchoolSubjects;
using Kreta.Desktop.ViewModels;
using Kreta.Desktop.ViewModels.Login;
using Kreta.Desktop.ViewModels.SchoolCitizens;
using Kreta.Desktop.ViewModels.SchoolGrades;
using Kreta.Desktop.ViewModels.SchoolSubjects;
using Kreta.Desktop.Views;
using Kreta.Desktop.Views.ControlPanel;
using Kreta.Desktop.Views.Login;
using Kreta.Desktop.Views.SchoolCitizens;
using Kreta.Desktop.Views.SchoolClasses;
using Kreta.Desktop.Views.SchoolGrades;
using Kreta.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;

namespace Kreta.Desktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            services.AddSingleton<StudentViewModel>();
            services.AddSingleton(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });

            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });
            // School classes
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });
            // School subject
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });
            services.AddSingleton<SubjectsViewModel>();
            services.AddSingleton(s => new SubjectsView()
            {
                DataContext = s.GetRequiredService<SubjectsViewModel>()
            });
            services.AddSingleton<TeacherSubjectsViewModel>();
            services.AddSingleton(s => new TeacherSubjectsView()
            {
                DataContext = s.GetRequiredService<TeacherSubjectsViewModel>()
            });
            services.AddSingleton<SchoolClassSubjectsViewModel>();
            services.AddSingleton(s => new SchoolClassSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolClassSubjectsViewModel>()
            });
            //School Grade
            services.AddSingleton<SchoolGradeViewModel>();
            services.AddSingleton(s => new SchoolGradeView()
            {
                DataContext = s.GetRequiredService<SchoolGradeViewModel>()
            });
            services.AddSingleton<ClosingEndOfYearGradeViewModel>();
            services.AddSingleton(s => new ClosingEndOfYearGradeView()
            {
                DataContext = s.GetRequiredService<ClosingEndOfYearGradeViewModel>()
            });
            services.AddSingleton<ClosingSemesterGradeViewModel>();
            services.AddSingleton(s => new ClosingSemesterGradeView()
            {
                DataContext = s.GetRequiredService<ClosingSemesterGradeViewModel>()
            });
            services.AddSingleton<CurrentSchoolHoursViewModel>();
            services.AddSingleton(s => new CurrentSchoolHoursView()
            {
                DataContext = s.GetRequiredService<CurrentSchoolHoursViewModel>()
            });
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton(s => new TaughtClassesView()
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()
            });

        }
    }
}
