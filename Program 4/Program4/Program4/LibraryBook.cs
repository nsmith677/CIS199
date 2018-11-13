using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class LibraryBook
    {
        //Define backing fields
        public string _title;
        public string _author;
        public string _publisher;
        public int _copyrightYear;
        public string _callNumber;
        public bool _checkedOutStatus = false;
        public bool _isReturned = false;

        //Precondition:
        //Postcondition: assigns variables
        public LibraryBook(string t, string a, string p, int cy, string cn)
        {
            Title = t;
            Author = a;
            Publisher = p;
            CopyrightYear = cy;
            CallNumber = cn;           
        
        }

        public string Title
        {
            //Precondition:
            //Postcondition:
            get
            {
                return _title;
            }

            //Precondition:
            //Postcondition:
            set
            {
                _title = value;
            }
        }

        public string Author
        {
            //Precondition:
            //Postcondition: 
            get
            {
                return _author;
            }

            //Precondition:
            //Postcondition: author is assigned value
            set
            {
                _author = value;
            }
        }

        public string Publisher
        {
            //Precondition:
            //Postcondition:
            get
            {
                return _publisher;
            }

            //Precondition:
            //Postcondition: publisher is assigned value
            set
            {
                _publisher = value;
            }
        }

        public int CopyrightYear
        {
            //Precondition:
            //Postcondition:
            get
            {
                return _copyrightYear;
            }

            //Precondition:
            //Postcondition: copyrightYear is assigned value
            set
            {
                if (value >= 0)
                {
                    _copyrightYear = value;
                }
                else
                {
                    _copyrightYear = 2016;
                }
                
            }
        }

        public string CallNumber
        {
            //Precondition:
            //Postcondition:
            get
            {
                return _callNumber;
            }

            //Precondition:
            //Postcondition:callNumber is assigned value
            set
            {
                _callNumber = value;
            }
        }

        //Precondition: Checked out status is false
        //Postcondition: checked out status is true
        public void CheckOut()
        {
            _checkedOutStatus = true;
        }


        //Precondition: Checked out status is true
        //Postcondition: Checked out status is reset to false
        public void ReturnToShelf()
        {
            _isReturned = true;
            _checkedOutStatus = false;
        }

        //Precondition: Checked out status is false
        //Postcondition: Checked out status will be true
        public bool IsCheckedOut()
        {
            if (_checkedOutStatus == true)
            {
                return _checkedOutStatus;
            }
            else
            {
                return _checkedOutStatus;
            }
        }

        //Precondition:
        //Postcondition: Creates data string
        public override string ToString()
        {
            string result;

            result = "Title: " + _title + Environment.NewLine + "Author: " + _author + Environment.NewLine + "Publisher: " + _publisher
            + Environment.NewLine + "Copyright Year: " + _copyrightYear + Environment.NewLine + "Call Number: " + _callNumber
            + Environment.NewLine + "Checked Out Status: " + _checkedOutStatus;

            return result;


        }
    }
}
