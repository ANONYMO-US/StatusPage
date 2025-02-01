using FluentValidation;

namespace TaskmanagementApi.Serversidevalidation
{
    public class TaskValidator : AbstractValidator<DataLayer.Task>
    {
        public TaskValidator() 
        {
            RuleFor(x => x.Description).NotNull();
        }
    }
}
