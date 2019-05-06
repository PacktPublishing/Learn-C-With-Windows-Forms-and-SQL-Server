using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;//needed for File use
using System.Diagnostics;//needed to open up excel from our code Process.Start
using Microsoft.Office.Interop.Excel;//needed to make an excel object in our code
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication5
{
    public partial class BizContacts : Form
    {
        string connString = @"Data Source=DESKTOP-4L6NSGO\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;//this object here allows us to build the connection between the program and the database
        System.Data.DataTable table;//table to hold the information so we can fill the datagrid view
        SqlConnection conn;//declares a variable to hold the sql connection
        string selectionStatement = "Select * from BizContacts";//used throughout so it's placed here

        public BizContacts()
        {
            InitializeComponent();
        }

        private void BizContacts_Load(object sender, EventArgs e)
        {

            cboSearch.SelectedIndex = 0;//first item in combobox is selected when the form loads
            dataGridView1.DataSource = bindingSource1;//sets the source of the data to be displayed in the grid view
                                                      //also binding source encapsulates the data for the form

            //line below calls a method called GetData
            //The argument is a string that represents an sql query
            //select * from BizContacts means select all the data from the biz contacts table
            GetData(selectionStatement);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);//pass in the select command and the connection string
                table = new System.Data.DataTable();//make a new data table object
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);//fill the data table
                bindingSource1.DataSource = table;//set the data source on the binding source to the table
                dataGridView1.Columns[0].ReadOnly = true;//this helps prevent the id field from being changed
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//show a useful message to the user of the program
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command;//declares a new sql command object
            //field names in the table
            string insert = @"insert into BizContacts(Date_Added, Company, Website, Title, First_Name, Last_Name,Address,
                                                      City,State,Postal_Code,Mobile,Notes,Image) 

                              values(@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name,@Address,
                                                      @City,@State,@Postal_Code,@Mobile,@Notes,@Image)"; //parameter names

            using (conn = new SqlConnection(connString)) //using allows disposing of low level resources
            {
                try
                {
                    conn.Open();//open the connection
                    command = new SqlCommand(insert, conn);//create the the new sql command object
                    command.Parameters.AddWithValue(@"Date_Added", dateTimePicker1.Value.Date);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Company", txtCompany.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Website", txtWebsite.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Title", txtTitle.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"First_Name", txtFName.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Last_Name", txtLName.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Address", txtAddress.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"City", txtCity.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"State", txtState.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Postal_Code", txtPostalCode.Text);//read value from form and save to table
                    command.Parameters.AddWithValue(@"Mobile", txtMobile.Text);
                    command.Parameters.AddWithValue(@"Notes", txtNotes.Text);
                    if (dlgOpenImage.FileName != "") //check whether file name is not empty
                        command.Parameters.AddWithValue(@"Image", File.ReadAllBytes(dlgOpenImage.FileName));//convert images to bytes for saving
                    else
                        command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;//save null to database 
                    command.ExecuteNonQuery();//push stuff into the table
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//if there is something wrong, show the user a message
                }
            }
            GetData(selectionStatement);
            dataGridView1.Update();//redraws the data grid view so the new record is visible on the bottom

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();//get the update command
            try
            {
                bindingSource1.EndEdit();//updates the table that is in memory in our program
                dataAdapter.Update(table);//actually updates the data base
                MessageBox.Show("Update Successful!");//confirms to user update is saved to actual table in sql server
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show message to the user
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;//grab a reference to the current row
            string value = row.Cells["ID"].Value.ToString();//grab the value from the id field of the selected record
            string fname = row.Cells["First_Name"].Value.ToString();//grab the value from the field name field of the selected record
            string lname = row.Cells["Last_Name"].Value.ToString();//grab the value from the last name field of the selected record
            DialogResult result = MessageBox.Show("Do you really want to delete " + fname + " " + lname + ", record " + value, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string deleteState = @"Delete from BizContacts where id = '" + value + "'";//this is the sql to delete the records from the sql table

            if (result == DialogResult.Yes) //check whether user really wants to delete records
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();//try to open connection
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();//this line actually causes the deletion to run
                        GetData(selectionStatement);//get the data again
                        dataGridView1.Update();//redraw the data grid  with updated information
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);//runs when something is wrong with the connection
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())//present because we have a combo box
            {
                case "First Name":
                    //line below picks out records that contain whatever the text is typed into the search box
                    //this text can be at the beginning of the first name, in the middle or the end, same below for the other cases
                    GetData("select * from bizcontacts where lower(first_name) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
                case "Last Name":
                    GetData("select * from bizcontacts where lower(last_name) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
                case "Company":
                    GetData("select * from bizcontacts where lower(company) like '%" + txtSearch.Text.ToLower() + "%'");
                    break;
            }
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)//use if in case user cancels getting image and FileName is blank
                pictureBox1.Load(dlgOpenImage.FileName);//loads image from drive using the file name property of the dialog box
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Form();//make a new form
            frm.BackgroundImage = pictureBox1.Image;//set background image of new, preview form of image
            frm.Size = pictureBox1.Image.Size;//sets the size of the form to the size of the image so the image is wholly visible
            frm.Show();//show form with image;
        }

        private void btnExportOpen_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();//make a new excel object
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);//make a work book
            _Worksheet worksheet = null;//make a work sheet and for now set it to null
            try
            {
                worksheet = workbook.ActiveSheet;//set active sheet
                worksheet.Name = "Business Contacts";
                //because both data grids and excel sheets are tabular, use nested loops to write from one to the other
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; rowIndex++)//this loop controls the row number
                {
                    for (int colIndex = 0; colIndex < dataGridView1.Columns.Count; colIndex++)//this is needed to go over the columns of each row
                    {
                        if (rowIndex == 0)//because the first row at index 0 is the header row
                        {
                            //in Excel, row and column indexes begin at 1,1, not 0,0
                            //write out the header texts from the grid view to excel sheet
                            worksheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Columns[colIndex].HeaderText;

                        }
                        else
                        {
                            //fix the row index at 1, then change the column index over its possible values from 0 to 5
                            worksheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();
                        }
                    }

                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //user clicks ok
                {
                    workbook.SaveAs(saveFileDialog1.FileName);//save file to drive
                    Process.Start("excel.exe", saveFileDialog1.FileName);//load excel with the exported file
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show message in case of errors
            }
            finally //this code always runs
            {
                excel.Quit();
                 workbook = null;//make workbook object null
                excel = null;
            }
        }

        private void btnSaveToText_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)//check whether somebody has clicked the ok button
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                 
                  foreach (DataGridViewColumn col in dataGridView1.Columns) //this is not in the video, but this code writes the headers to the file
                        sw.Write(col.HeaderText);

                    foreach (DataGridViewRow row in dataGridView1.Rows) //grab each row in the data grid view
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                            sw.Write(cell.Value);
                        sw.WriteLine();//this pushes the cursor to the next line
                    }
                }
                Process.Start("notepad.exe", saveFileDialog1.FileName);//open file in notepad after the file is written to the drive
            }

        }

        private void btnOpenWord_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word._Application word = new Microsoft.Office.Interop.Word.Application();//make a new word object
            Document doc = word.Documents.Add();//make a new document
            Microsoft.Office.Interop.Word.Range rng = doc.Range(0, 0);
            Table wdTable = doc.Tables.Add(rng, dataGridView1.Rows.Count, dataGridView1.Columns.Count);//make anew table based on our data grid view
            wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;//make a thick outer border
            wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;//mkae the cell lines thin
            try
            {
                doc = word.ActiveDocument;//make an active document in word
                //i is the row index from the data grid view
                for(int i=0;i<dataGridView1.Rows.Count-1;i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)//this loop is needed to step through the columns of each row
                        //line below runs several times, each time writing the cell value from the grid to word

                        if (i== 0)//because the first row at index 0 is the header row
                        {
                         
                            //write out the header texts from the grid view to word table
                            //line below runs as many times as there are cells whose text needs to be copied out to word
                            wdTable.Cell(i + 1, j + 1).Range.InsertAfter(dataGridView1.Columns[j].HeaderText);

                        }
                        else
                        {
                            //line below runs when data, not headers, is copied from the datagridview to the word table
                           wdTable.Cell(i + 1 , j+1).Range.InsertAfter(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                }
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    doc.SaveAs(saveFileDialog1.FileName);//save file to drive
                    Process.Start("winword.exe", saveFileDialog1.FileName);//open the document in word after the table is made
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//show a box with a message if there is an error
            }
            finally
            {
                word.Quit();//quit word
                word = null;
                doc = null;//clean up the word object and document object
            }
        }
    }
}


