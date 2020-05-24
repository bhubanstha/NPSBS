using System.Windows.Forms;

namespace Education.Common
{
    public class Response
    {
        public static void SaveMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show("Information successfully recorded.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information could not be recorded at this time.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show("Information successfully removed.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information could not be removed at this time.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show("Information successfully updated.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information could not be updated at this time.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BulkUploadMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show(rowsAffected.ToString() + " record(s) from the excel file uploaded.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no record to upload.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void TeansferMessage(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                MessageBox.Show(rowsAffected.ToString() + " student(s) transferred successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no student to transfer.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GenericError(string ex)
        {
            MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Success(string msg)
        {
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
