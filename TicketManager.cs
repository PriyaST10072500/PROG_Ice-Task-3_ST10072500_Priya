using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_Ice_Task_3_ST10072500_Priya
{
    public class TicketManager
    {
        private Stack<UndoAction> undoStack = new Stack<UndoAction>();
        private Queue<Ticket> ticketQueue = new Queue<Ticket>();
        public List<Ticket> ticketList = new List<Ticket>();
        private Dictionary<int, Ticket> ticketDictionary = new Dictionary<int, Ticket>();

        //creates a new ticket
        public void CreateTicket(string description)
        {
            int ticketNumber = GenerateTicketNumber();
            Ticket newTicket = new Ticket(ticketNumber, description);


            ticketQueue.Enqueue(newTicket);
            ticketList.Add(newTicket);
            ticketDictionary.Add(ticketNumber, newTicket);


            undoStack.Push(new UndoAction { Action = PROG_Ice_Task_3_ST10072500_Priya.UndoAction.ActionType.Create, AffectedTicket = newTicket });
        }

        //sets process value to true
        public void ProcessTicket()
        {
            if (ticketQueue.Any())
            {
                Ticket nextTicket = ticketQueue.Dequeue();
                nextTicket.Process();


                undoStack.Push(new UndoAction { Action = PROG_Ice_Task_3_ST10072500_Priya.UndoAction.ActionType.Process, AffectedTicket = nextTicket });
            }
            else
            {
                Console.WriteLine("No tickets to process.");
            }
        }

        //Undo's the previous action by the user
        public void UndoAction()
        {
            if (undoStack.Any())
            {
                UndoAction lastAction = undoStack.Pop();
                switch (lastAction.Action)
                {
                    case PROG_Ice_Task_3_ST10072500_Priya.UndoAction.ActionType.Create:
                        ticketQueue.Dequeue();
                        ticketList.Remove(lastAction.AffectedTicket);
                        ticketDictionary.Remove(lastAction.AffectedTicket.TicketNumber);
                        break;
                    case PROG_Ice_Task_3_ST10072500_Priya.UndoAction.ActionType.Process:
                        lastAction.AffectedTicket.UndoAction();
                        ticketQueue.Enqueue(lastAction.AffectedTicket);
                        break;

                }
            }
            else
            {
                Console.WriteLine("No actions to undo.");
            }
        }

        public void ViewTickets()
        {
            foreach (var ticket in ticketList)
            {
                Console.WriteLine($"Ticket Number: {ticket.TicketNumber}, Description: {ticket.Description}, Processed: {ticket.IsProcessed}");
            }
        }

        //searches for a ticket depending on the number
        public Ticket SearchTicket(int ticketNumber)
        {
            if (ticketDictionary.ContainsKey(ticketNumber))
            {
                return ticketDictionary[ticketNumber];
            }
            else
            {
                Console.WriteLine("Ticket not found.");
                return null;
            }
        }

        //Modifies the ticket depending on the ticket number
        public void ModifyTicket(int ticketNumber, string newDescription)
        {
            if (ticketDictionary.ContainsKey(ticketNumber))
            {
                Ticket ticketToModify = ticketDictionary[ticketNumber];
                ticketToModify.Description = newDescription;


                undoStack.Push(new UndoAction { Action = PROG_Ice_Task_3_ST10072500_Priya.UndoAction.ActionType.Modify, AffectedTicket = ticketToModify });
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }
        }

        //display by ticket number in ascending order or in alphabetical order
        public void SortTickets(bool byTicketNumber)
        {
            if (byTicketNumber)
            {
                ticketList = ticketList.OrderBy(t => t.TicketNumber).ToList();
            }
            else
            {
                ticketList = ticketList.OrderBy(t => t.Description).ToList();
            }
        }

        //displays the ticket by sort option
        public void DisplaySortedTickets()
        {
            ViewTickets();
        }

        //generates a random number for the ticket
        private int GenerateTicketNumber()
        {

            return new Random().Next(1000, 9999);
        }

    }
}


// References
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started

