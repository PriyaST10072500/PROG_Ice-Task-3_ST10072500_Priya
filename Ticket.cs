using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_3_ST10072500_Priya
{
    public class Ticket
    {
        public int TicketNumber { get; set; }
        public string Description { get; set; }
        public bool IsProcessed { get; set; }

        public Ticket(int ticketNumber, string description)
        {
            TicketNumber = ticketNumber;
            Description = description;
            IsProcessed = false;
        }

        //Set process status from False to True
        public void Process()
        {
            IsProcessed = true;
        }

        //undo the previous action
        public void UndoAction()
        {
            IsProcessed = false;
        }

        //deletes a task
        public void Delete()
        {
            //Undo does delete
        }

        // display ticket details in list
        public override string ToString()
        {
            return $"Ticket Number: {TicketNumber}, Description: {Description}, Processed: {IsProcessed}";
        }


    }
}


// References
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started
