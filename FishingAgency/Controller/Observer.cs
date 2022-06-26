using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public class Observer
    {
        private string name;
        private string observerState;
        private Subject subject;
        // Constructor
        public Observer(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public void Update()
        {
            observerState = subject.State;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }
        // Gets or sets subject
        public Subject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
