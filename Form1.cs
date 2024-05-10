using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PROG_Ice_Task_3_ST10072500_Priya
{
    public partial class Form1 : Form
    {
        private TicketManager ticketManager;

        public Form1()
        {
            InitializeComponent();
            ticketManager = new TicketManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //undo the create, process and modify
        private void undoBtn_Click(object sender, EventArgs e)
        {
            ticketManager.UndoAction();
            RefreshTicketList();

        }

        //creates the ticket
        private void createBtn_Click(object sender, EventArgs e)
        {

            string description = descriptionIn.Text;
            ticketManager.CreateTicket(description);
            RefreshTicketList();

        }

        //sets process to true
        private void processBtn_Click(object sender, EventArgs e)
        {
            ticketManager.ProcessTicket();
            RefreshTicketList();

        }

        //Searches for a ticket depending on its number
        private void searchBtn_Click(object sender, EventArgs e)
        {
            int ticketNumber = int.Parse(searchIn.Text);
            Ticket ticket = ticketManager.SearchTicket(ticketNumber);
            if (ticket != null)
            {
                //  ticket details here, the list is shown by default
            }

        }

        //Modifies the ticket description depending on ticket number
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            int ticketNumber = int.Parse(modifyTicketNum.Text);
            string newDescription = newDescriptionIn.Text;
            ticketManager.ModifyTicket(ticketNumber, newDescription);
            RefreshTicketList();

        }

        //sorts the tickets by number or description
        private void sortBtn_Click(object sender, EventArgs e)
        {
            bool byTicketNumber = radioButton1.Checked;
            ticketManager.SortTickets(byTicketNumber);
            RefreshTicketList();

        }


        //refreshes the display list to display new tickets 
        private void RefreshTicketList()
        {
            listBox1.Items.Clear();
            foreach (var ticket in ticketManager.ticketList)
            {
                listBox1.Items.Add(ticket);
            }
        }


    }
}
