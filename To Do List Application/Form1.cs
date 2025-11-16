using System.Data;
using System.Net;

namespace To_Do_List_Application
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        DataTable todolist = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // create columns
            todolist.Columns.Add("Title");
            todolist.Columns.Add("Description");

            // point datagridview to source
            viewToDo.DataSource = todolist;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bHinzufügen_Click(object sender, EventArgs e)
        {
            todolist.Rows.Add(tTask.Text, tDescription.Text);

            // danach Eingabefelder leeren
            tTask.Text = "";
            tDescription.Text = "";
        }



        private void lAdd_Click(object sender, EventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            isEditing = true;

            //Fill Textboxes with data from selected task
            tTask.Text = todolist.Rows[viewToDo.CurrentCell.RowIndex].ItemArray[0].ToString();
            tDescription.Text = todolist.Rows[viewToDo.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void bEntfernen_Click(object sender, EventArgs e)
        {
            if (viewToDo.CurrentCell != null && viewToDo.CurrentCell.RowIndex >= 0 && viewToDo.CurrentCell.RowIndex < todolist.Rows.Count)
            {
                todolist.Rows[viewToDo.CurrentCell.RowIndex].Delete();
            }
            else
            {
                MessageBox.Show("Keine Aufgabe ausgewählt oder Liste ist leer.");
            }
        }



        private void bSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todolist.Rows[viewToDo.CurrentCell.RowIndex]["Title"] = tTask.Text;
                todolist.Rows[viewToDo.CurrentCell.RowIndex]["Description"] = tDescription.Text;
            }
            else
            {
                todolist.Rows.Add(tTask.Text, tDescription.Text);
            }
            // clear textboxes
            tTask.Text = "";
            tDescription.Text = "";
            isEditing = false;
        }

    }
}
