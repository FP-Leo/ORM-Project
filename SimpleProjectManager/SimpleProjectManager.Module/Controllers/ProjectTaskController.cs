using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using SimpleProjectManager.Module.BusinessObjects;

namespace SimpleProjectManager.Module.Controllers
{

    public partial class ProjectTaskController : ViewController
    {

        public ProjectTaskController()
        {
            // Specify the type of objects that can use the Controller.
            TargetObjectType = typeof(ProjectTask);
            // Activate the Controller in any type of View.
            TargetViewType = ViewType.Any;

            SimpleAction markCompletedAction = new SimpleAction(this, "MarkCompleted",
                DevExpress.Persistent.Base.PredefinedCategory.RecordEdit)
            {
                TargetObjectsCriteria =
                (CriteriaOperator.FromLambda<ProjectTask>(t => t.Status != ProjectTaskStatus.Completed)).ToString(),
                ConfirmationMessage =
                "Are you sure you want to mark the selected task(s) as 'Completed'?",
                ImageName = "State_Task_Completed"
            };

            markCompletedAction.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;

            markCompletedAction.Execute += (s, e) => {
                foreach (ProjectTask task in e.SelectedObjects)
                {
                    task.EndDate = DateTime.Now;
                    task.Status = ProjectTaskStatus.Completed;
                    View.ObjectSpace.SetModified(task);
                }
                View.ObjectSpace.CommitChanges();
                View.ObjectSpace.Refresh();
            };
        }
    }

    // ...
}