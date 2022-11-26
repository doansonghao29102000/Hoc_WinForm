using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HelloWordForm
{
    public partial class LearnDataGridViewForm : Form
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public LearnDataGridViewForm()
        {
            InitializeComponent();
            CreateFakeData();
        }
        private void CreateFakeData()
        {
            Students.Add(new Student("SV1001", "Trần Trung Đức", "CNTT", new DateTime(2009, 10, 15), 3.15f));
            Students.Add(new Student("SV1002", "Lê Văn Hùng", "CNTT", new DateTime(2009, 3, 17), 3.45f));
            Students.Add(new Student("SV1003", "Ma văn Thắng", "CNTT", new DateTime(2009, 9, 25), 3.55f));
            Students.Add(new Student("SV1004", "Trần Ngô Mỹ Duyên", "CNTT", new DateTime(2009, 12, 11), 3.35f));
            Students.Add(new Student("SV1005", "Lê Hoàng Diệp Thảo", "CNTT", new DateTime(2009, 1, 14), 3.65f));
            Students.Add(new Student("SV1006", "Nguyễn Mai Trần Long", "CNTT", new DateTime(2009, 11, 15), 3.25f));
            Students.Add(new Student("SV1007", "Hoàng Đức Sơn", "CNTT", new DateTime(2009, 4, 27), 3.75f));
            Students.Add(new Student("SV1008", "Nông Văn Tấn", "CNTT", new DateTime(2009, 2, 18), 3.05f));
            Students.Add(new Student("SV1009", "Chu Đình Dũng", "CNTT", new DateTime(2009, 10, 30), 3.15f));
            Students.Add(new Student("SV1010", "Ma Thùy Quyên", "CNTT", new DateTime(2009, 8, 28), 3.45f));
        }
        private void FillData()
        {
            dataGridView.Rows.Clear();
            foreach (var item in Students)
            {
                dataGridView.Rows.Add(item.ToPropertiesArray());
            }
        }
        private void FillDataHandler(object sender, EventArgs e)
        {
            FillData();
        }

        private void UpdateTableDataHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["colRemove"].Index
                && e.RowIndex != -1)
            {
                var row = dataGridView.Rows[e.RowIndex];
                var id = row.Cells["colID"].Value.ToString();
                var indexToRemove = FindIndex(id);
                if (indexToRemove > -1)
                {
                    var confirmAns = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?",
                        "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmAns == DialogResult.Yes)
                    {
                        Students.RemoveAt(indexToRemove);
                        FillData();
                        MessageBox.Show($"Xóa thành công sinh viên mã \" {id} \" !",
                        "Kết quả xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        //Phương thức tìm đối tượng cần xóa trong danh sách gốc
        private int FindIndex(string id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (id.CompareTo(Students[i].Id) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
