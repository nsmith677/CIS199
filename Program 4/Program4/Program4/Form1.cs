/* A7872
 * CIS199-01
 * Program 4
 * 12/6/2016
 * A program that will allow you to check out a book, view details on the book, and return it. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List to hold LibraryBook objects
        List<LibraryBook> bookList = new List<LibraryBook>();

        int cyInput; //To hold copyright year input
        string titleInput;
        string authorInput;
        string pubInput;
        string cnInput;
        bool checkedOutStatus = false;
            
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            //Create LibraryBook object
            LibraryBook myBook = new LibraryBook(titleInput, authorInput, pubInput, cyInput, cnInput);

            //Get the book data
            GetBookData(myBook);

            //Add the object to the list
            bookList.Add(myBook);

            //Add an entry to the list box
            bookListBox.Items.Add(myBook.Title);

            //Clear the textbox controls
            titleTxtBox.Clear();
            authorTxtBox.Clear();
            pubTxtBox.Clear();
            cyTxtBox.Clear();
            cnTxtBox.Clear();

            //Reset focus
            titleTxtBox.Focus();

        }


        //Precondition: Book data is entered into text box
        //Postcondition: Book data is held
        private void GetBookData (LibraryBook book)
        {
            //Get the book data
            book.Title = titleTxtBox.Text;
            book.Author = authorTxtBox.Text;
            book.Publisher = pubTxtBox.Text;
            book.CallNumber = cnTxtBox.Text;

            if (int.TryParse(cyTxtBox.Text, out cyInput))
            {
                book.CopyrightYear = cyInput;
            }
            else
            {
                MessageBox.Show("Invalid Copyright Year!");
            }

        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedIndex >= 0)
            {
                int index = bookListBox.SelectedIndex; //get the index

                MessageBox.Show(bookList[index].ToString()); //display result
            }
            else
            {
                MessageBox.Show("Select book.");

            }   
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedIndex >= 0) //select an item
            {
                int index = bookListBox.SelectedIndex; //Get the index
                bookList[index].CheckOut(); //use method to change to true
                MessageBox.Show(bookList[index].Title + " has been checked out."); //display result

            }
            else
            {
                MessageBox.Show("Select book.");
            }


        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedIndex >= 0)
            {
                int index = bookListBox.SelectedIndex; //get the index
                bookList[index].ReturnToShelf(); //use method to change to flase
                MessageBox.Show(bookList[index].Title + " has been returned."); //display result
            }
            else
            {
                MessageBox.Show("Select book.");
            }
        }
    }
}
