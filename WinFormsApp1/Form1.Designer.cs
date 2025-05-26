namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFilterCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSortByAge;
        private System.Windows.Forms.Button btnFilterCity;
        private System.Windows.Forms.Button btnAvgAge;
        private System.Windows.Forms.Button btnSelectNames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFilterCity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFilterCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSortByAge = new System.Windows.Forms.Button();
            this.btnFilterCity = new System.Windows.Forms.Button();
            this.btnAvgAge = new System.Windows.Forms.Button();
            this.btnSelectNames = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFilterCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(460, 200);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Labels
            this.lblName.Text = "Имя:";
            this.lblName.Location = new System.Drawing.Point(12, 225);

            this.lblAge.Text = "Возраст:";
            this.lblAge.Location = new System.Drawing.Point(12, 255);

            this.lblCity.Text = "Город:";
            this.lblCity.Location = new System.Drawing.Point(12, 285);

            this.lblFilterCity.Text = "Фильтр (Город):";
            this.lblFilterCity.Location = new System.Drawing.Point(250, 225);

            // TextBoxes
            this.txtName.Location = new System.Drawing.Point(80, 222);
            this.txtAge.Location = new System.Drawing.Point(80, 252);
            this.txtCity.Location = new System.Drawing.Point(80, 282);
            this.txtFilterCity.Location = new System.Drawing.Point(350, 222);

            // Buttons
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Location = new System.Drawing.Point(80, 320);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(180, 320);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnSortByAge.Text = "Сортировка по возрасту";
            this.btnSortByAge.Location = new System.Drawing.Point(12, 360);
            this.btnSortByAge.Click += new System.EventHandler(this.btnSortByAge_Click);

            this.btnFilterCity.Text = "Фильтровать по городу";
            this.btnFilterCity.Location = new System.Drawing.Point(250, 252);
            this.btnFilterCity.Click += new System.EventHandler(this.btnFilterCity_Click);

            this.btnAvgAge.Text = "Средний возраст";
            this.btnAvgAge.Location = new System.Drawing.Point(250, 282);
            this.btnAvgAge.Click += new System.EventHandler(this.btnAvgAge_Click);

            this.btnSelectNames.Text = "Показать имена";
            this.btnSelectNames.Location = new System.Drawing.Point(250, 320);
            this.btnSelectNames.Click += new System.EventHandler(this.btnSelectNames_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtFilterCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblFilterCity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSortByAge);
            this.Controls.Add(this.btnFilterCity);
            this.Controls.Add(this.btnAvgAge);
            this.Controls.Add(this.btnSelectNames);
            this.Text = "Управление людьми";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
