
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.GroupBox();
            this.btnCalcAge = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.CountrySelector = new System.Windows.Forms.DomainUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Country = new System.Windows.Forms.Label();
            this.txtStudies = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.DateOfBirth1 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txttLastName = new System.Windows.Forms.TextBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(51, 33);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(53, 15);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Form
            // 
            this.Form.AutoSize = true;
            this.Form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Form.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Form.Controls.Add(this.btnCalcAge);
            this.Form.Controls.Add(this.btnSalir);
            this.Form.Controls.Add(this.radioButtonNo);
            this.Form.Controls.Add(this.radioButtonYes);
            this.Form.Controls.Add(this.DateOfBirth);
            this.Form.Controls.Add(this.CountrySelector);
            this.Form.Controls.Add(this.button2);
            this.Form.Controls.Add(this.button1);
            this.Form.Controls.Add(this.Country);
            this.Form.Controls.Add(this.txtStudies);
            this.Form.Controls.Add(this.Age);
            this.Form.Controls.Add(this.txtAge);
            this.Form.Controls.Add(this.DateOfBirth1);
            this.Form.Controls.Add(this.LastName);
            this.Form.Controls.Add(this.txttLastName);
            this.Form.Controls.Add(this.Nombre);
            this.Form.Controls.Add(this.txtName);
            this.Form.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Form.Location = new System.Drawing.Point(169, 76);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(322, 268);
            this.Form.TabIndex = 2;
            this.Form.TabStop = false;
            this.Form.Text = "Registro";
            // 
            // btnCalcAge
            // 
            this.btnCalcAge.Location = new System.Drawing.Point(241, 114);
            this.btnCalcAge.Name = "btnCalcAge";
            this.btnCalcAge.Size = new System.Drawing.Size(75, 23);
            this.btnCalcAge.TabIndex = 19;
            this.btnCalcAge.Text = "Calcular ";
            this.btnCalcAge.UseVisualStyleBackColor = true;
            this.btnCalcAge.Click += new System.EventHandler(this.btnCalcAge_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(241, 223);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(188, 176);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNo.TabIndex = 17;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(112, 176);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(35, 19);
            this.radioButtonYes.TabIndex = 16;
            this.radioButtonYes.Text = "Si";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(112, 85);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(110, 23);
            this.DateOfBirth.TabIndex = 15;
            this.DateOfBirth.Tag = "";
            // 
            // CountrySelector
            // 
            this.CountrySelector.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.CountrySelector.AllowDrop = true;
            this.CountrySelector.Items.Add("Argentina");
            this.CountrySelector.Items.Add("Brasil");
            this.CountrySelector.Items.Add("Peru");
            this.CountrySelector.Location = new System.Drawing.Point(112, 143);
            this.CountrySelector.Name = "CountrySelector";
            this.CountrySelector.ReadOnly = true;
            this.CountrySelector.Size = new System.Drawing.Size(110, 23);
            this.CountrySelector.TabIndex = 14;
            this.CountrySelector.Text = "Choise country";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Acept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Acept);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(74, 145);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(28, 15);
            this.Country.TabIndex = 11;
            this.Country.Text = "Pais";
            // 
            // txtStudies
            // 
            this.txtStudies.AutoSize = true;
            this.txtStudies.Location = new System.Drawing.Point(12, 178);
            this.txtStudies.Name = "txtStudies";
            this.txtStudies.Size = new System.Drawing.Size(94, 15);
            this.txtStudies.TabIndex = 10;
            this.txtStudies.Text = "Posee estudios?";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(72, 117);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 15);
            this.Age.TabIndex = 9;
            this.Age.Text = "Edad";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(112, 114);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 23);
            this.txtAge.TabIndex = 6;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateOfBirth1
            // 
            this.DateOfBirth1.AutoSize = true;
            this.DateOfBirth1.Location = new System.Drawing.Point(0, 88);
            this.DateOfBirth1.Name = "DateOfBirth1";
            this.DateOfBirth1.Size = new System.Drawing.Size(107, 15);
            this.DateOfBirth1.TabIndex = 4;
            this.DateOfBirth1.Text = "Fecha  nacimiento";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(51, 60);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(52, 15);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Apellido";
            // 
            // txttLastName
            // 
            this.txttLastName.Location = new System.Drawing.Point(112, 57);
            this.txttLastName.Name = "txttLastName";
            this.txttLastName.Size = new System.Drawing.Size(110, 23);
            this.txttLastName.TabIndex = 2;
            this.txttLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttLastName.TextChanged += new System.EventHandler(this.txttLastName_TextChanged);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.Form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Form.ResumeLayout(false);
            this.Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.GroupBox Form;
        private System.Windows.Forms.TextBox txttLastName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label txtStudies;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label DateOfBirth1;
        private System.Windows.Forms.DomainUpDown CountrySelector;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Button btnCalcAge;
    }
}

