using CommunityToolkit.Mvvm.Input;
using MiMascotaMaui.Models;

namespace MiMascotaMaui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}