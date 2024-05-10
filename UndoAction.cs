using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_3_ST10072500_Priya
{
    public class UndoAction
    {
        public enum ActionType
        {
            Create,
            Process,
            Modify,
            Delete
        }

        public ActionType Action { get; set; }
        public Ticket AffectedTicket { get; set; }

        public void Undo()
        {
            switch (Action)
            {
                case ActionType.Create:
                    AffectedTicket.Delete();
                    break;
                case ActionType.Process:
                    AffectedTicket.UndoAction();
                    break;
                case ActionType.Modify:

                    break;
                case ActionType.Delete:

                    break;
                default:
                    break;
            }
        }
    }
}


// References
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started