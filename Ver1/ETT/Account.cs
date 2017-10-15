using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver1.ETT
{
    class Account
    {
        private string ID;

        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Pass;

        public string _Pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        private bool Note;

        public bool _Note
        {
            get { return Note; }
            set { Note = value; }
        }

        private DateTime DateTimePlayer;

        public DateTime _DateTimePlayer
        {
            get { return DateTimePlayer; }
            set { DateTimePlayer = value; }
        }
    }
}
